using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatControl : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("is_walking", true);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("is_running", true);
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                animator.SetBool("is_running", false);
            }
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("is_walking", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("is_back", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("is_back", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("is_right", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("is_right", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("is_left", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("is_left", false);
        }
    }
}

