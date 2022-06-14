using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(jugador))]
public class enemigo : MonoBehaviour
{
    public Animator animacion;
    public jugador move;
    public Transform jugador;
    public float rango;

    public void start()
    {
        move = GetComponent<jugador>();
    }



    public void Update()
    {
        //Vector3 forward = transform.TransformDirection(transform.forward);
        //Vector3 toOther = jugador.position - transform.position;

        //if(Vector3.Dot(forward , toOther) < 0)
        //{
        //    print("DETRAS DE TI IMBECIL");
        //}

        Look();
        if(Physics.Raycast(jugador.position , jugador.forward , out RaycastHit hit))
        {
            if(hit.transform.name == "Player")
            {
                Debug.Log("trae esas nalgas ");
            }
        }
    }

    void Look()
    {
        if(Vector3.Distance(transform.position,jugador.position)<=rango)
        {
            if(Vector3.Dot((jugador.position-transform.position).normalized, transform.TransformDirection(Vector3.forward).normalized) > -2f)
            {
                move.Mover(0, 1);
                
                if (Vector3.Dot((jugador.position-transform.position).normalized, transform.TransformDirection(Vector3.right).normalized) > 0f)
                {
                    move.RotacionPersonaje(10f);
                }
                else
                {
                    move.RotacionPersonaje(-10f);
                }
            }
            animacion.SetFloat("speedmovement", 1);

        }
        else 
        {
            animacion.SetFloat("speedmovement", 0);
        }
    }
}
