using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Switch : MonoBehaviour
{
    Camera main;
    Camera secondary;

    void Start()
    {
        main = GameObject.Find("Third Person Camera").GetComponent<Camera>();
        secondary = GameObject.Find("First Person Camera").GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && main.enabled)
        {
            secondary.enabled = true;
            main.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && secondary.enabled)
        {
            main.enabled = true;
            secondary.enabled = false;
        }
    }
}
