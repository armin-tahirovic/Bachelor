using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ram : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
   {
       if (other.gameObject.CompareTag("Pc_Ram"))
       {
           GameObject.FindGameObjectWithTag("End_PC").GetComponent<PcComplete>().end += 1;
       }
   }
}
