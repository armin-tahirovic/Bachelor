using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
  public void GameEnd()
  {
    StartCoroutine(Pressed());
  }

  public void ResumeGame()
  {
    TimerCount.pressed = true;

    StartCoroutine(Resume());
  }

  IEnumerator Pressed()
  {
    if (GameManager.IsGuest)
    {
      SceneManager.LoadScene("LoginScene");
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

      var message =
        $"{{\"Time\":\"{time}\", \"ID_Game\":\"{id_game}\",\"ID_Student\":\"{id_student}\", \"ID_Opgave\":\"{id_assignment}\",\"Score\":\"{score}\",\"Hints\":\"{hints}\", \"isDone\":\"{isDone}\",\"LastCheckpoint\":\"{lastCheckpoint}\"}}";
      var postData = System.Text.Encoding.UTF8.GetBytes(message);

      var ws = new UnityWebRequest("https://vrlearn.azure-api.net/FunctionVRLEarn/Afslut", "Post");
      ws.uploadHandler = (UploadHandler) new UploadHandlerRaw(postData);
      ws.downloadHandler = (DownloadHandler) new DownloadHandlerBuffer();
      ws.SetRequestHeader("Content-Type", "application/json");
      yield return ws.SendWebRequest();

      SceneManager.LoadScene("LoginScene");
    }
  }

  IEnumerator Resume()
  {
    SceneManager.LoadScene("SampleScene");
    yield break;
  }
}
