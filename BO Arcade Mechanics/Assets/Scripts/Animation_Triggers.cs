using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Triggers : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.ResetTrigger("Left Up");
            animator.ResetTrigger("Right Down");
            animator.ResetTrigger("Right Up");
            animator.SetTrigger("Left Down");
        }
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetTrigger("Left Up");
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.ResetTrigger("Right Up");
            animator.ResetTrigger("Left Down");
            animator.ResetTrigger("Left Up");
            animator.SetTrigger("Right Down");
        }
        else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetTrigger("Right Up");
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y <= 4)
        {
            animator.SetTrigger("Jump");
        }
    }
}