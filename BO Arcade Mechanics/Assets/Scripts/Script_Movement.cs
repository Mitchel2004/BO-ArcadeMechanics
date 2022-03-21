using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Movement : MonoBehaviour
{
    Rigidbody rb;
    bool check = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position += new Vector3(0, 0, 20) * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-10, 0, 0) * Time.deltaTime;
            Vector3 direction1 = new Vector3(0, 0, 22.5f);
            Quaternion targetRotation1 = Quaternion.Euler(direction1);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation1, Time.deltaTime * 22.5f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(10, 0, 0) * Time.deltaTime;
            Vector3 direction2 = new Vector3(0, 0, -22.5f);
            Quaternion targetRotation2 = Quaternion.Euler(direction2);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation2, Time.deltaTime * 22.5f);
        }
        else if (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false)
        {
            Vector3 directionBack1 = new Vector3(0, 0, 0);
            Quaternion targetRotationBack1 = Quaternion.Euler(directionBack1);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotationBack1, Time.deltaTime * 22.5f);
        }

        if (Input.GetKey(KeyCode.Space) && transform.position.y < 4)
        {
            rb.constraints = RigidbodyConstraints.None;
            rb.velocity = new Vector3(0, 10, 0);
        }
        else if (transform.position.y < 4)
        {
            rb.constraints = RigidbodyConstraints.FreezePositionY;
            check = false;
        }

        if (transform.position.y > 4 && transform.position.y < 8 && check == false)
        {
            Vector3 directionUp = new Vector3(-11.25f, 0, 0);
            Quaternion targetRotationUp = Quaternion.Euler(directionUp);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotationUp, Time.deltaTime * 45f);
        }
        else if (transform.position.y > 8)
        {
            check = true;
            Vector3 directionBack2 = new Vector3(0, 0, 0);
            Quaternion targetRotationBack2 = Quaternion.Euler(directionBack2);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotationBack2, Time.deltaTime);
        }
    }
}
