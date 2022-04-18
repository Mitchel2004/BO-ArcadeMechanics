using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    Image image;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        image = GameObject.FindGameObjectWithTag("HD").GetComponent<Image>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            image.enabled = false;
        }

        if (image.enabled == false)
        {
            transform.position += new Vector3(0, 0, 20) * Time.deltaTime;

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(-10, 0, 0) * Time.deltaTime;
            }
            
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(10, 0, 0) * Time.deltaTime;
            }
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