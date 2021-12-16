using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooler : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PC_Cooler"))
        {
            GameObject.FindGameObjectWithTag("End_PC").GetComponent<PcComplete>().end += 1;
        }
    }
}
