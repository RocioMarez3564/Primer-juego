using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 sensibility;
    public float rotMin = -60;
    public float rotMax = 60;

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
        float rotationX = Input.GetAxis("Mouse X") * sensibility.x;
        float rotationY = Input.GetAxis("Mouse Y") * sensibility.y;

        transform.Translate(new Vector3(ejeX, 0.0f, ejeZ) * Time.deltaTime * speed);

        if(rotationX != 0)
        {
            transform.Rotate(Vector3.up * rotationX * Time.deltaTime);
        }
        if(rotationY != 0)
        {
            float angle = (Camera.localEulerAngles.x - rotationY + 360) % 360;
            if(angle > 180) { angle -= 360; }
            angle = Mathf.Clamp(angle, -80, 80);
            Camera.localEulerAngles = Vector3.right * angle;
        }
    }
}