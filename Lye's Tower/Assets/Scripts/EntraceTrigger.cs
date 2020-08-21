using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EntraceTrigger : MonoBehaviour
{
    public CameraController main;
    public PlayerMovement player;

    public float xTarget;
    public float yTarget;
    
    public bool tp;
    public Vector3 tpPos;
    public bool stopMovement = true;

    public UnityEvent OnTriggerEvent;

    void OnTriggerEnter2D(Collider2D other) {
        main.xTarget = xTarget;
        main.yTarget = yTarget;

        if(tp) {
            if(stopMovement) {
                player.tp = true;
            }
            player.transform.position = tpPos;
        }

        OnTriggerEvent.Invoke();
    }
}
