using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using InputDevice = UnityEngine.XR.InputDevice;

public class TestEndScene : MonoBehaviour
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
    SceneManager.LoadScene("EndScene");
  }
}
