using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impulsar : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

            rb.AddForce(transform.up * 10, ForceMode.Impulse);
        
    }
}
