using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
  public GuestData[] guest;
  public RowUI rowUI;
  public GameObject nicknameUI;

  public IEnumerator GetScoresFromServer()
  {
    var ws = UnityWebRequest.Get("https://vrlearn.azure-api.net/FunctionVRLEarn/GuestScoreBoard");
    yield return ws.SendWebRequest();

    var json = JsonConvert.DeserializeObject<Guests>("{\"guests\":" + ws.downloadHandler.text + "}");
    guest = json.guests;
    StartCoroutine(Score());
  }

  IEnumerator Score()
  {
    var scores = GetGuest();
    for (int i = 0; i < 4; i++)
    {
      var row = Instantiate(rowUI, transform).GetComponent<RowUI>();
      row.index.text = (i + 1).ToString();
      row.username.text = scores[i].nickname;
      row.score.text = scores[i].highscore.ToString();
    }
    yield return scores;

    nicknameUI.SetActive(false);
  }

  GuestData[] GetGuest()
  {
    return guest.OrderByDescending(x => x.highscore).ToArray();
  }
}
