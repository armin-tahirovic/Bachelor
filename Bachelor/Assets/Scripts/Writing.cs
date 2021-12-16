using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Writing : MonoBehaviour
{
  public InputField firstInputField;
  public InputField secondInputField;
  private TouchScreenKeyboard _overlayKeyboard;

  void Update()
  {
    if (_overlayKeyboard != null && firstInputField.isFocused)
    {
      firstInputField.text = _overlayKeyboard.text;
    }

    if (_overlayKeyboard != null && secondInputField.isFocused)
    {
      secondInputField.text = _overlayKeyboard.text;
    }
  }

  public void Focus()
  {
    _overlayKeyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
  }
}
