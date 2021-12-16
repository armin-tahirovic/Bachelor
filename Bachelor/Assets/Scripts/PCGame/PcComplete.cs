using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PcComplete : MonoBehaviour
{

    public int end;
    public Text output;
    public static bool isFinished;
    // Update is called once per frame
    void Update()
    {
        if (end == 7)
        {
            isFinished = true;
            output.text = "Done";
        }

    }
}
