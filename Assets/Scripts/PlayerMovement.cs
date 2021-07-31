using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float sensibility = 32f;
    public float sensMin = -60;
    public float sensMax = 60;

    private float speed = 7f;
    private Transform Camera;    
    private Rigidbody Physics;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        Camera = transform.Find("PlayerCamera");
        Physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento del personaje
        float ejeX = Input.GetAxis("Horizontal");
        float ejeZ = Input.GetAxis("Vertical");
        float rotationX = Input.GetAxis("Mouse X");
        float rotationY = Input.GetAxis("Mouse Y");

        transform.Translate(new Vector3(ejeX, 0.0f, ejeZ) * Time.deltaTime * speed);

        if(rotationY <= sensMin)
        {
            rotationY = sensMin;
        }
        if(rotationY >= sensMax)
        {
            rotationY = sensMax;
        }
        transform.Rotate(Vector3.up * rotationX * Time.deltaTime * sensibility);
        Camera.Rotate(Vector3.left * rotationY * Time.deltaTime * sensibility);
    }
}