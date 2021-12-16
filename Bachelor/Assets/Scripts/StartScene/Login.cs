using System.Collections;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
  public InputField usernameIf;
  public InputField passwordIf;
  public Text output;

  public void StartGame()
  {
    StartCoroutine(Pressed());
  }

  IEnumerator Pressed()
  {
    var username = usernameIf.text;
    var password = passwordIf.text;

    if (username != "" && password != "")
    {
      var message = $"{{\"Username\":\"{username}\", \"Password\":\"{password}\", \"ID_Spil\":\"{1}\"}}";
      var postData = System.Text.Encoding.UTF8.GetBytes(message);

      var ws = new UnityWebRequest("https://vrlearn.azure-api.net/FunctionVRLEarn/Login", "Post");
      ws.uploadHandler = (UploadHandler) new UploadHandlerRaw(postData);
      ws.downloadHandler = (DownloadHandler) new DownloadHandlerBuffer();
      ws.SetRequestHeader("Content-Type", "application/json");
      yield return ws.SendWebRequest();

      if (ws.downloadHandler.text != "Wrong Login")
      {
        var json = JsonConvert.DeserializeObject<PlayerData>(ws.downloadHandler.text);
        GameManager.IdStudent = json.id;
        GameManager.IdGame = json.iD_Opgave;
        GameManager.Score = json.highscore;
        GameManager.NiveauPermission = json.niveauPermission;
        GameManager.Checkpoint = json.checkpoint;
        GameManager.Hint = json.hints;
        GameManager.IsDone = json.isDone;
        SceneManager.LoadScene("SampleScene");
      }
      else
      {
        output.text = "Forkert log ind";
      }
    }
    else
    {
      output.text = "Udfyld felterne";
    }
  }
}
