using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zonaSalto : MonoBehaviour

{ public bool JumpPlatform;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody  temporal = other.gameObject.GetComponent<Rigidbody>();
        if (JumpPlatform)
        {
            temporal.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
        else
        {
            temporal.AddForce(other.transform.forward * 5, ForceMode.Impulse);
        }
    }

  
}
