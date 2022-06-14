using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    [Header("Movimiento personaje")]
    public float SpeedMovement;
    public Vector3 Direccion;
    public CharacterController controller;


    [Header("Movimiento camara")]
    public Camera camarapersonaje;
    public Vector2 camara;
    public float rotacionCamaraX;
    public float rotacionCameraY;

    [Header("gravedad")]
    public Vector3 gravedad;
    public float salto;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Update()
    {
        //if (controller.isGrounded && gravedad.y < 0)
        //{
        //    gravedad.y = -2;
        //}
        if (controller.isGrounded == false)
        {
            
            gravedad.y += -9.8f * Time.deltaTime;
        }
        controller.Move(transform.TransformDirection(gravedad) * Time.deltaTime );
    }
    public void Mover(float horizontal, float vertical)
    {
        Direccion.x = horizontal;
        Direccion.z = vertical;
        controller.Move(transform.TransformDirection(Direccion) * Time.deltaTime * SpeedMovement);

    }

    public void RotacionCamara(float rotacioncamara)
    {
        rotacionCamaraX -= rotacioncamara;
        rotacionCamaraX = Mathf.Clamp(rotacionCamaraX, -90, 90);
        camarapersonaje.transform.localRotation = Quaternion.Euler(rotacionCamaraX, 0, 0);
    }
    public void RotacionPersonaje(float rotacionpersonaje)
    {

        rotacionCameraY += rotacionpersonaje;

        controller.transform.rotation = Quaternion.Euler(0, rotacionCameraY, 0);     
    }
    public void Salto()
    {
        if (controller.isGrounded)
        {
            gravedad.y = Mathf.Sqrt(salto * -2 * -9.8f);
        }
        
    }
    public void Correr()
    {
        if (Input.GetButton("Correr"))
        {
            Direccion.z = Direccion.z * 2;
        }
    }
}
