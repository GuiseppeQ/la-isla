using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparando : MonoBehaviour
{
    public GameObject Mira;
    public GameObject bala;

    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, vertical * 3);
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(bala, Mira.transform.position, Mira.transform.rotation);
        }
    }
}