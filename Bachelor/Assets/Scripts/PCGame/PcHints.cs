using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class PcHints : MonoBehaviour
{
    [SerializeField] private float threshold = .1f;
    [SerializeField] private float deadZone = .025f;

    private Vector3 _startPos;
    private ConfigurableJoint _joint;

    private int _hintNumber = 0;


    // Start is called before the first frame update
    void Start()
    {
        _startPos = transform.localPosition;
        _joint = GetComponent<ConfigurableJoint>();
    }

    private InputDevice _device;
    // Update is called once per frame
    void Update()
    {
        if (GetValue() + threshold >= 1)
            Pressed();
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
      GameObject.FindGameObjectWithTag("PC_Graphics").transform.position =
        new Vector3(8.05500031f, 1.20000005f, -3.10099936f);
        _hintNumber += 1;
    }
}
