using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicsCard : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PC_Graphics"))
        {
            GameObject.FindGameObjectWithTag("End_PC").GetComponent<PcComplete>().end += 1;
        }
    }
}
