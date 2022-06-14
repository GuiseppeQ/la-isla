using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacciones : MonoBehaviour
{
    public Transform camarajugador;
    public PlayerState playerState;
    public float distancia;
    public Transform tomar, arma;
    public LayerMask capita;
   


    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag=="Open")
        {

            other.GetComponentInParent<animacion>().OpendDoor();

        }
        if (other.tag == "Bateria")
        {
            other.GetComponentInParent<baterias>();
            
        }
    }

    private void Update()
    {

        Debug.DrawRay(camarajugador.position, camarajugador.forward * 5f, Color.black);
        RaycastHit hit;
        if (Physics.Raycast(camarajugador.position, camarajugador.forward, out hit, distancia, capita) && capita == LayerMask.GetMask("interaccion"))
        {
            
            if (hit.transform.tag == "Box")
            {
                //indicarle al jugador el objeto
                if (Input.GetButtonDown("Fire1"))
                {
                    hit.transform.parent = tomar;
                    hit.transform.GetComponent<Rigidbody>().isKinematic = true;
                    hit.transform.position = tomar.position;
                    capita = LayerMask.GetMask("Default");
                }
            }
        }
        else if (tomar.childCount != 0 && Input.GetButtonDown("Fire1"))
        {
            tomar.GetComponentInChildren<Rigidbody>().isKinematic = false;
            tomar.transform.DetachChildren();
            capita = LayerMask.GetMask("interaccion");

        }
        if (Physics.Raycast(camarajugador.position, camarajugador.forward, out hit, distancia, capita) && capita == LayerMask.GetMask("interaccion"))
        {
            Debug.Log("tengo adelante" + hit.transform.name);
            if (hit.transform.tag == "Arma")
            {
                //indicarle al jugador el objeto
                if (Input.GetKey(KeyCode.E))
                {
                    arma.parent = tomar;
                    hit.transform.GetComponent<Rigidbody>().isKinematic = true;
                    arma.position = tomar.position;
                                                            
                    arma.rotation = tomar.rotation;
                    capita = LayerMask.GetMask("Default");
                }
            }
        }
        else if (tomar.childCount != 0 && Input.GetButtonDown("Fire1"))
        {
            tomar.GetComponentInChildren<Rigidbody>().isKinematic = false;
            tomar.transform.DetachChildren();
            capita = LayerMask.GetMask("interaccion");

        }








    }
      
}
