using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;

public class AssignmentManager : MonoBehaviour
{
  public AssignmentData[] assignment;
  public AssignmentRowUI rowUI;

  private void Start()
  {
    StartCoroutine(GetAssignmentsFromServer());
  }

  IEnumerator GetAssignmentsFromServer()
  {
    var ws = UnityWebRequest.Get("https://vrlearn.azure-api.net/FunctionVRLEarn/Assignments");
    yield return ws.SendWebRequest();

    var json = JsonConvert.DeserializeObject<Assignments>("{\"assignments\":" + ws.downloadHandler.text + "}");
    assignment = json.assignments;
    StartCoroutine(Assignments());
  }

  IEnumerator Assignments()
  {
    var scores = GetAssignments();
    for (int i = 0; i < 6; i++)
    {
      var row = Instantiate(rowUI, transform).GetComponent<AssignmentRowUI>();
      row.index.text = (i + 1).ToString();
      row.name_Assignment.text = scores[i].name_Assignment;
      row.subject.text = scores[i].subject;
    }

    yield return scores;
  }

  AssignmentData[] GetAssignments()
  {
    return assignment.OrderByDescending(x => x.subject).ToArray();
  }
}
