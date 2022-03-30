using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazers : MonoBehaviour
{
    public float LifeTime;

    void Start()
    {
        transform.Rotate(90f, 0f, 0f);
    }

    void Update()
    {
        
        Invoke("Destroy", LifeTime);
    }
    private void Destroy()
    {
        Destroy(gameObject);
    }
}
