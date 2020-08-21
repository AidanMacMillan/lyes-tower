using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float xTarget = 0f;
    public float yTarget = 0f;

    
    void Update() {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, xTarget, 0.05f), Mathf.Lerp(transform.position.y, yTarget, 0.05f), -10);
    }
}
