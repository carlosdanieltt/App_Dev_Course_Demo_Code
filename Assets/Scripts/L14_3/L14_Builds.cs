using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L14_Builds : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(0, Mathf.Sin(Time.time) * 2, 0);
        transform.Rotate(new Vector3(0, 0, -Time.fixedDeltaTime * 90));

        spriteRenderer.color = new Color(Time.time % 2.0f, Time.time % 5.0f, Time.time % 9.0f);
    }
}
