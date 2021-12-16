using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseNiveau : MonoBehaviour
{
  void Start()
  {
    switch (GameManager.NiveauPermission)
    {
      case 1:
        gameObject.SetActive(true);
        break;
      case 2:
        gameObject.SetActive(true);
        break;
      case 3:
        gameObject.SetActive(false);
        break;
      default:
        gameObject.SetActive(true);
        break;
    }
  }
}
