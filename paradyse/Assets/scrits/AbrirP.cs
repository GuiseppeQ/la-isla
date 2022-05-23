using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirP : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag=="open")
        {

        }
    }

    public void OnTriggerStay(Collider other)
    {
        
    }
   
    public void OnTriggerExit(Collider other)
    {
        
    }

}
