using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUser : MonoBehaviour
{
  public GameObject guestCanvas;
  public GameObject studentCanvas;
  void Start()
  {
    guestCanvas.SetActive(false);
    studentCanvas.SetActive(false);

    if (GameManager.IsGuest)
    {
      guestCanvas.SetActive(true);
    }
    else
    {
      studentCanvas.SetActive(true);
    }
  }
}
