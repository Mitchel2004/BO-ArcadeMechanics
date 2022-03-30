using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Destroy : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}