using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCollider : MonoBehaviour
{
  private int box;

  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("BlueBox"))
      box = 1;

    if (other.gameObject.CompareTag("RedBox"))
      box = 2;

    if (other.gameObject.CompareTag("GreenBox"))
      box = 3;

    if (other.gameObject.CompareTag("BlueBall") && box == 1)
    {
      gameObject.transform.Rotate(0f, 0f, -110f);
      Invoke(nameof(RotateBack), 2f);
    }

    if (other.gameObject.CompareTag("RedBall") && box == 2)
    {
      gameObject.transform.Rotate(0f, 0f, -110f);
      Invoke(nameof(RotateBack), 2f);
    }

    if (other.gameObject.CompareTag("GreenBall") && box == 3)
    {
      gameObject.transform.Rotate(0f, 0f, -110f);
      Invoke(nameof(RotateBack), 2f);
    }

    if (other.gameObject.CompareTag("BlueBall") && box != 1)
    {
      gameObject.transform.Rotate(0f, 0f, 110f);
      Invoke(nameof(RotateBack), 2f);
    }

    if (other.gameObject.CompareTag("RedBall") && box != 2)
    {
      gameObject.transform.Rotate(0f, 0f, 110f);
      Invoke(nameof(RotateBack), 2f);
    }

    if (other.gameObject.CompareTag("GreenBall") && box != 3)
    {
      gameObject.transform.Rotate(0f, 0f, 110f);
      Invoke(nameof(RotateBack), 2f);
    }
  }

  void RotateBack()
  {
    gameObject.transform.eulerAngles = new Vector3(0, 90, 0);
  }
}
