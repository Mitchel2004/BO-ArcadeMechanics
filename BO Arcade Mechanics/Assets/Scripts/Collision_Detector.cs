using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Detector : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "HP")
        {
            Debug.Log("+25 Gezondheidspunten");
        }

        if (collision.gameObject.tag == "PU")
        {
            //Debug.Log("Kracht Omhoog");
        }

        if (collision.gameObject.tag == "HD")
        {
            //Debug.Log("Hieperrijden");
            rb.velocity = new Vector3(0, 0, 10);
        }
    }
}
