using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public float movespeed = 10.0f;
    public float rotatespeed = 45.0f;
    public Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Vertical");
        float rotateInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * moveInput * movespeed * Time.deltaTime);

        transform.Rotate(Vector3.up * rotateInput * rotatespeed * Time.deltaTime);
    }
}
