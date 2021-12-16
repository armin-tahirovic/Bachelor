using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveGate : MonoBehaviour
{
  [SerializeField]
  private float threshold = .1f;
  [SerializeField]
  private float deadZone = .025f;

  private Vector3 _startPos;
  private ConfigurableJoint _joint;
  public GameObject gate;

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
      gate.SetActive(false);
    else
      gate.SetActive(true);
  }

  float GetValue()
  {
    var value = Vector3.Distance(_startPos, transform.localPosition) / _joint.linearLimit.limit;
    if (Math.Abs(value) < deadZone)
      value = 0;

    return Mathf.Clamp(value, -1f, 1f);
  }
}
