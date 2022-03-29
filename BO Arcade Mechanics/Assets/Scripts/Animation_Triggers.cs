using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Triggers : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.CrossFade("Left Down", 0.5f);
        }
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.CrossFade("Left Up", 0.5f);
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.CrossFade("Right Down", 0.5f);
        }
        else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.CrossFade("Right Up", 0.5f);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.CrossFade("Jump", 0.5f);
        }
    }
}