using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsFinished : MonoBehaviour
{
  public static int balls;
  public static bool isFinished;
  void Update ()
  {
    if (balls == 3)
    {
      isFinished = true;
    }
  }
}

