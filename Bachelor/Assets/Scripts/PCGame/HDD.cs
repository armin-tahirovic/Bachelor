using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDD : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PC_HDD"))
        {
            GameObject.FindGameObjectWithTag("End_PC").GetComponent<PcComplete>().end += 1;
        }
    }
}
