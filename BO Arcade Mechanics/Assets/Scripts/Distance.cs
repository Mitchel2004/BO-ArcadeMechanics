using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    Text distanceText;
    
    void Start()
    {
        distanceText = GameObject.Find("Distance Text").GetComponent<Text>();
    }

    void Update()
    {
        if ((transform.position.z / 10) >= 1000) {
            distanceText.text = (transform.position.z / 10000).ToString("F2") + "km";
        }
        else
        {
            distanceText.text = ((int)transform.position.z / 10).ToString() + "m";
        }
    }
}
