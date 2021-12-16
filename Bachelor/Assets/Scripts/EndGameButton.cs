using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class EndGameButton : MonoBehaviour
{
  [SerializeField] private float threshold = .1f;
  [SerializeField] private float deadZone = .025f;

  private Vector3 _startPos;
  private ConfigurableJoint _joint;

  private bool pressed;

  // Start is called before the first frame update
  void Start()
  {
    _startPos = transform.localPosition;
    _joint = GetComponent<ConfigurableJoint>();
  }

  // Update is called once per frame
  void Update()
  {
    if (GetValue() + threshold >= 1)
      StartCoroutine(End());

    if (pressed)
      TimerCount.pressed = false;
  }

  float GetValue()
  {
    var value = Vector3.Distance(_startPos, transform.localPosition) / _joint.linearLimit.limit;
    if (Math.Abs(value) < deadZone)
      value = 0;

    return Mathf.Clamp(value, -1f, 1f);
  }

  IEnumerator End()
  {
    pressed = true;
    if (GameManager.IsGuest)
    {
      SceneManager.LoadScene("EndScene");
    }
    else
    {
      GameManager.Score = Mathf.CeilToInt((GameManager.Timer * 10 - 20000) / GameManager.Hint);
      var score = GameManager.Score;
      var id_game = GameManager.IdGame;
      var id_student = GameManager.IdStudent;
      var id_assignment = GameManager.IdAssignment;
      var time = GameManager.Timer;
      var hints = GameManager.Hint;
      var isDone = GameManager.IsDone;
      var lastCheckpoint = GameManager.Checkpoint;

      var message = $"{{\"Time\":\"{time}\", \"ID_Game\":\"{id_game}\",\"ID_Student\":\"{id_student}\",\"ID_Opgave\":\"{id_assignment}\",\"Score\":\"{score}\",\"Hints\":\"{hints}\", \"isDone\":\"{isDone}\",\"LastCheckpoint\":\"{lastCheckpoint}\"}}";
      var postData = System.Text.Encoding.UTF8.GetBytes(message);

      var ws = new UnityWebRequest("https://vrlearn.azure-api.net/FunctionVRLEarn/Afslut", "Post");
      ws.uploadHandler = (UploadHandler) new UploadHandlerRaw(postData);
      ws.downloadHandler = (DownloadHandler) new DownloadHandlerBuffer();
      ws.SetRequestHeader("Content-Type", "application/json");
      yield return ws.SendWebRequest();

      SceneManager.LoadScene("EndScene");
    }
  }
}
