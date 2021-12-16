using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBoxIsFinished : MonoBehaviour
{
  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("BlueBall"))
      IsFinished.balls += 1;
  }
}


