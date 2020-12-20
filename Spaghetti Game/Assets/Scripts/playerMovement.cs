using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 5f;

    float horizontalMove = 0f;

    public Animator animator;

    bool jump = false;

    void Update()
    {
        
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Horizontal",Input.GetAxisRaw("Horizontal"));
        
        if(Input.GetButtonDown("Jump")){
            jump = true;
        }
        
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime,false,jump);
        jump = false;
    }
}
