using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class andar : MonoBehaviour
{ float xDir, yDir, jumpForce = 4;
    Rigidbody rg;
    private void Start()
    {
        rg = GetComponent<Rigidbody>();
        
    }
    void Update()
    {
        xDir = Input.GetAxis("Horizontal");
        yDir = Input.GetAxis("Vertical");
        transform.Rotate(0, xDir * 0.4f, 0);
        rg.velocity = transform.forward * 20 * yDir;


        //transform.Translate(0,0, yDir* 0.05f);
        if (Input.GetButtonDown("Jump"))
        {
            rg.AddForce(transform.up * jumpForce, ForceMode.Impulse);
                }

        
    }
}
