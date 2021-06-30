using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 1f;
    public float Sensibility = 1f;
    public float Jumpforce = 1f;

    private Rigidbody Physics;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        Physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento del personaje
        float ejeX = Input.GetAxis("Horizontal");
        float ejeZ = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(ejeX, 0.0f, ejeZ) * Time.deltaTime * Speed);

        // Rotación de la cámara
        float rotationY = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0, rotationY * Time.deltaTime * Sensibility, 0));
    }
}