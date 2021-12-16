using System;
using UnityEngine;
using UnityEngine.UI;


public class CheckAndGate : MonoBehaviour
{
  public bool check;
  public Text output;
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
    output.text = check.ToString();
  }

  private void CheckBool()
  {
    output.text = "whii";
    if (check && GameObject.FindGameObjectWithTag("LightButtonOnePush").GetComponent<ControlLight>().check &&
        GameObject.FindGameObjectWithTag("LightButtonTwoPush").GetComponent<ControlLight>().check)
    {
      output.text = "inside";
      material.EnableKeyword("_EMISSION");
    }
    else
    {
      material.DisableKeyword("_EMISSION");
    }
  }
}
