using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motherboard : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pc_Motherboard"))
        {
            GameObject.FindGameObjectWithTag("End_PC").GetComponent<PcComplete>().end += 1;
        }
    }
}
