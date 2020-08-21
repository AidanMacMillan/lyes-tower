using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    private Vector3 pos;
    public bool show;

    void Start() {
        pos = transform.position;
        spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 0);
        transform.Translate(Vector3.down * 2);
    }

    void Update() {
        if(show) {
            transform.position = new Vector3(transform.position.x, Mathf.Lerp(transform.position.y, pos.y, 0.005f), transform.position.z);
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, Mathf.Lerp(spriteRenderer.color.a, 1.0f, 0.005f));
        }
    }

    public void Show() {
        show = true;
    }
}
