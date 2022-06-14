using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nueva : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnPoint;
    public float incremento;

    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }


    void Shoot()
    {
        GameObject GO = Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody RB = GO.GetComponent<Rigidbody>();
        RB.AddForce(GO.transform.forward * incremento, ForceMode.Impulse);
    }
}
