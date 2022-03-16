using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

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
        else if (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false && Input.GetKey(KeyCode.LeftArrow) == false && Input.GetKey(KeyCode.RightArrow) == false)
        {
            
        }

        if (Input.GetKey(KeyCode.Space) && transform.position.y <= 4)
        {
            rb.constraints = RigidbodyConstraints.None;
            rb.velocity = new Vector3(0, 10, 0);
        }
        else if (transform.position.y <= 4)
        {
            rb.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }
}
