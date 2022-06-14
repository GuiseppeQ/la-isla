using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuevo : MonoBehaviour
{
    public Transform other;

    private void Update()
    {
        if (other)
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 toOther = other.position - transform.position;

            if (Vector3.Dot(forward, toOther) < 0)
            {
                print("el enemigo me persigue");
            }
        }
    }
}
