using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCount : MonoBehaviour
{
  [SerializeField]
  private float threshold = .1f;
  [SerializeField]
  private float deadZone = .025f;

  private Vector3 _startPos;
  private ConfigurableJoint _joint;

  public static bool pressed;
  public Text timer;

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
      StartCoroutine(StartTime());

    if (pressed)
      timer.text = (GameManager.Timer += Time.deltaTime).ToString("F1");
  }

  float GetValue()
  {
    var value = Vector3.Distance(_startPos, transform.localPosition) / _joint.linearLimit.limit;
    if (Math.Abs(value) < deadZone)
      value = 0;

    return Mathf.Clamp(value, -1f, 1f);
  }

  IEnumerator StartTime()
  {
    yield return pressed = true;
  }
}
