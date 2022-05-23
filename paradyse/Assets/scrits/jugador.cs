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


    private void Update()
    {
        Direccion.x = Input.GetAxis("Horizontal");
        Direccion.z = Input.GetAxis("Vertical");

        if (Input.GetButton("Correr"))
        {
            Direccion.z = Direccion.z * 2;
        }

        controller.Move(transform.TransformDirection (Direccion * Time.deltaTime)*SpeedMovement);



        camara.x = Input.GetAxis("Mouse X");
        camara.y = Input.GetAxis("Mouse Y");

        rotacionCamaraX -= camara.y;
        rotacionCameraY += camara.x;

        rotacionCamaraX = Mathf.Clamp (rotacionCamaraX,-40,40);

        camarapersonaje.transform.localRotation = Quaternion.Euler(rotacionCamaraX,0,0);


        controller.transform.rotation = Quaternion.Euler(0,rotacionCameraY,0);

        gravedad.y += -9.8f * Time.deltaTime;
        controller.Move(gravedad * Time.deltaTime);


        if (controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            gravedad.y = Mathf.Sqrt(salto * -2 * -9.8f);
        }
        if (controller.isGrounded && gravedad.y < 0)
        {
            gravedad.y = -2;
        }
        

        
    }
}
