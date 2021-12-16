using System;
using UnityEngine;
using UnityEngine.UI;


public class ButtonThreeAndFour : MonoBehaviour
{
  public bool check;
  public Material material;

  private void Awake()
  {
    material.DisableKeyword("_EMISSION");
  }

  private void Update()
  {
    CheckBool();
  }

  private void OnTriggerEnter(Collider other)
  {
    check = true;
  }

  private void CheckBool()
  {
    if (check && GameObject.FindGameObjectWithTag("LightButtonThreePush").GetComponent<ControlLight>().check &&
        GameObject.FindGameObjectWithTag("LightButtonFourPush").GetComponent<ControlLight>().check)
    {
      material.EnableKeyword("_EMISSION");
    }
    else
    {
      material.DisableKeyword("_EMISSION");
    }
  }
}
