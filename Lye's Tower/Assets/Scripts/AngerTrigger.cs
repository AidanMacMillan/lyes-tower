using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerTrigger : MonoBehaviour
{
    int count = 0;
    public PlayerMovement playerMovement;
    public CharacterController2D  characterController;

    public int targetSpeed;
    public int targetJump;

    void OnTriggerEnter2D(Collider2D other) {
        count++;
        if(count > 8) {
            playerMovement.runSpeed = targetSpeed;
            characterController.m_JumpForce = targetJump;
        }
    }
}
