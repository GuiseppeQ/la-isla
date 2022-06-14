using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    public GameObject plataform;
    public Transform minposition;
    public Transform maxposition;
    public float velocidad;

    public void OnTriggerStay(Collider other)
    {
        if (other != null)
        {
            Moveplataform();
        }
    }

    private void Moveplataform()
    {
        if (plataform.transform.position.y >= maxposition.transform.position.y && velocidad > 0)
        {
            velocidad = velocidad * -1;
        }
        if (plataform.transform.position.y <= minposition.transform.position.y && velocidad < 0)
        {
            velocidad = velocidad * -1;
        }

        plataform.transform.Translate(Vector3.up * Time.deltaTime * velocidad);        
    }           
}
