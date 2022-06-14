using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(jugador))]
public class playercontroller : MonoBehaviour
{  
    [Header("Movimiento personaje")]
    jugador playermovement;
    public float direccionX;
    public float direccionY;

    [Header("Rotacion Camara")]
    public float rotacionCamaraX;
    public float rotacionCamaraY;
    public float mouseX;
    public float mouseY;

    private void Start()
    {
        playermovement = GetComponent<jugador>();      
    }
    public void Update()
    {
        direccionX = Input.GetAxis("Horizontal");
        direccionY = Input.GetAxis("Vertical");
        playermovement.Mover(direccionX, direccionY);


        mouseX = Input.GetAxis("Mouse X");
        playermovement.RotacionPersonaje(mouseX);

        mouseY = Input.GetAxis("Mouse Y");
        playermovement.RotacionCamara(mouseY);
    }



}
