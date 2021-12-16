using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using CommonUsages = UnityEngine.XR.CommonUsages;
using InputDevice = UnityEngine.XR.InputDevice;

public class PauseMenu : MonoBehaviour
{
  public InputActionReference ToggleReference = null;
  private InputDevice device;

  private void Awake()
  {
    ToggleReference.action.started += Toggle;
  }

  private void OnDestroy()
  {
    ToggleReference.action.started -= Toggle;
  }

  private void Toggle(InputAction.CallbackContext context)
  {
    TimerCount.pressed = false;
    SceneManager.LoadScene("PauseMenu");
  }
}
