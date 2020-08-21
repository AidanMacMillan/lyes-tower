using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    float horizontal = 0f;
    public float runSpeed = 1f;
    bool jump = false;

    public float lean = 3f;
    public bool tp = false;
    
    void Update()
    {
        if(tp) {
            horizontal = 0;
        } else {
            horizontal = Input.GetAxisRaw("Horizontal");
        }

        if(Input.GetButtonDown("Horizontal")) {
            tp = false;
        }

        if(Input.GetButtonDown("Jump")) {
            jump = true;
        }
    }

    void FixedUpdate() {
        controller.Move(horizontal * runSpeed * Time.fixedDeltaTime, false, jump);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, horizontal * -lean);
        jump = false;
    }
}
