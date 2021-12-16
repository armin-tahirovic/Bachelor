using System;
using UnityEngine;


public class ControlLightFour : MonoBehaviour
{
  [SerializeField] private float threshold = .1f;
  [SerializeField] private float deadZone = .025f;

  private Vector3 _startPos;
  private ConfigurableJoint _joint;
  public bool check;

  private void Awake()
  {
    GameObject.FindGameObjectWithTag("LedLamp4").GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    check = false;
  }

  // Start is called before the first frame update
  void Start()
  {
    _startPos = transform.localPosition;
    _joint = GetComponent<ConfigurableJoint>();
  }

  // Update is called once per frame
  void Update()
  {
    if (GetValue() + threshold >= 1)
    {
      Pressed();
    }
  }

  float GetValue()
  {
    var value = Vector3.Distance(_startPos, transform.localPosition) / _joint.linearLimit.limit;
    if (Math.Abs(value) < deadZone)
      value = 0;

    return Mathf.Clamp(value, -1f, 1f);
  }

  private void Pressed()
  {
    if (!check)
    {
      GameObject.FindGameObjectWithTag("LedLamp4").GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
      check = true;
    }
    else
    {
      GameObject.FindGameObjectWithTag("LedLamp4").GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
      check = false;
    }
  }
}
