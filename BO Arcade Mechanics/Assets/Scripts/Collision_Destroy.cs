using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Destroy : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}