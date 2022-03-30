using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision_Detector : MonoBehaviour
{
    Rigidbody rb;
    Image image;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        image = GameObject.Find("Empty Health Bar").GetComponent<Image>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ob")
        {
            if (image.rectTransform.sizeDelta.x < 390)
            {
                float size = image.rectTransform.sizeDelta.x + 39;
                image.rectTransform.sizeDelta = new Vector2(size, 40);
            }
        }

        if (other.gameObject.tag == "HP")
        {
            //Debug.Log("+25 Gezondheidspunten");

            if (image.rectTransform.sizeDelta.x > 0)
            {
                float size = image.rectTransform.sizeDelta.x - 39;
                image.rectTransform.sizeDelta = new Vector2(size, 40);
            }
        }

        if (other.gameObject.tag == "PU")
        {
            //Debug.Log("Kracht Omhoog");
        }

        if (other.gameObject.tag == "HD")
        {
            //Debug.Log("Hieperrijden");
            rb.velocity = new Vector3(0, 0, 10);
        }
    }
}
