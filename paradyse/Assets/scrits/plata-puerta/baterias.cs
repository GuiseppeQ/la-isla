using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baterias : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bateria")
        {
            other.gameObject.SetActive(false);
            other.GetComponent<PlayerState>().contadorDeBaterias++;
        }
    }
}
