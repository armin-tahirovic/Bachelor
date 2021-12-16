using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finished : MonoBehaviour
{
  public GameObject door;

  // Update is called once per frame
  void Update()
  {
    // All games finished
    if (IsFinished.isFinished && FinalLight.isFinished && PcComplete.isFinished)
    {
      door.SetActive(false);
      GameManager.Checkpoint = 4;
    }

    // If-Else game finished
    if (IsFinished.isFinished)
      GameManager.Checkpoint = 1;

    // Logic Gate game finished
    if (FinalLight.isFinished)
      GameManager.Checkpoint = 2;

    // Computer Parts game finished
    if (PcComplete.isFinished)
      GameManager.Checkpoint = 3;

    // If-Else and Logic gate game finished
    if (IsFinished.isFinished && FinalLight.isFinished)
      GameManager.Checkpoint = 5;

    // If-Else and Computer Parts game finished
    if (IsFinished.isFinished && PcComplete.isFinished)
      GameManager.Checkpoint = 6;

    // Logic Gate and Computer Parts game finished
    if (FinalLight.isFinished && PcComplete.isFinished)
      GameManager.Checkpoint = 7;
  }
}
