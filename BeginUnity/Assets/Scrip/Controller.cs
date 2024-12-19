using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    public float Speed = 10000;
    [SerializeField]
    public float turnSpeed = 30;

    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*//Set Position
        Vector3 movement = Vector3.zero;

        if(Input.GetKey(KeyCode.W))
        {
            movement += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement += Vector3.right;
        }

        transform.position += movement * Speed * Time.deltaTime;*/


        //rigidbody
        float turnX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            turnX = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            turnX = 1;
        }

        Vector3 movementVehicle = transform.forward * moveY * Speed * Time.deltaTime;

        rb.AddForce(movementVehicle);

        if(rb.velocity.magnitude > 0.1f)
        {
            float turnAngle = turnX * turnSpeed * Time.deltaTime;
            transform.Rotate(0f, turnAngle, 0f);
        }

    }
}
