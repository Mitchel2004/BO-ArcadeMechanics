using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position += new Vector3(0, 0, 20) * Time.deltaTime;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-10, 0, 0) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(10, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y <= 4)
        {
            rb.constraints = RigidbodyConstraints.None;
        }
        else if (transform.position.y <= 4)
        {
            rb.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }
}