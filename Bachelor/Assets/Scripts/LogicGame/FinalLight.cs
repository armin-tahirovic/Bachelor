using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLight : MonoBehaviour
{
  public static bool isFinished;
  void Update()
  {
    if (GameObject.FindGameObjectsWithTag("AndOneTag")[2].GetComponent<Renderer>().material
          .IsKeywordEnabled("_EMISSION") &&
        GameObject.FindGameObjectsWithTag("OrOneTag")[2].GetComponent<Renderer>().material
          .IsKeywordEnabled("_EMISSION") && GameObject.FindGameObjectsWithTag("AndTwoTag")[2]
          .GetComponent<Renderer>()
          .material.IsKeywordEnabled("_EMISSION"))
    {
      GameObject.FindGameObjectWithTag("FinalLight").GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
      isFinished = true;
    }
  }
}
