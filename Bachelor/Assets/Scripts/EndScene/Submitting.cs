using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Submitting : MonoBehaviour
{
  [SerializeField]
  private InputField username;
  public ScoreManager scoreManager;
  public GameObject scoreboard;

  void Start()
  {
    scoreboard.SetActive(false);
  }

  public void Submit()
  {
    StartCoroutine(SubmitToServer());
  }

  IEnumerator SubmitToServer()
  {
    GameManager.Score = Mathf.CeilToInt((GameManager.Timer * 10 - 20000) / GameManager.Hint);
    var score = GameManager.Score;
    var id_game = GameManager.IdGame;
    var guest = username.text;
    var time = GameManager.Timer;
    var hints = GameManager.Hint;

    var message = $"{{\"Time\":\"{time}\", \"ID_Game\":\"{id_game}\",\"Guest_Nick\":\"{guest}\", \"Score\":\"{score}\",\"Hints\":\"{hints}\"}}";
    var postData = System.Text.Encoding.UTF8.GetBytes(message);

    var ws = new UnityWebRequest("https://vrlearn.azure-api.net/FunctionVRLEarn/Afslut", "Post");
    ws.uploadHandler = (UploadHandler) new UploadHandlerRaw(postData);
    ws.downloadHandler = (DownloadHandler) new DownloadHandlerBuffer();
    ws.SetRequestHeader("Content-Type", "application/json");
    yield return ws.SendWebRequest();

    scoreboard.SetActive(true);
    StartCoroutine(scoreManager.GetScoresFromServer());
  }
}
