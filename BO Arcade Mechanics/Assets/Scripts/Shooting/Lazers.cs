using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazers : MonoBehaviour
{
    public float LifeTime;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(90f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        Invoke("Destroy", LifeTime);
    }
    private void Destroy()
    {
        Destroy(gameObject);
    }
}
