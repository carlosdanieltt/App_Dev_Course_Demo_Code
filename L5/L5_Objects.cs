using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5_Objects : MonoBehaviour
{
    public GameObject otherSprite;
    Vector2 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(2 * Mathf.Cos(Time.time) + offset[0], 2 * Mathf.Sin(Time.time) + offset[1], 0);

        //transform.position = new Vector3(2 * Mathf.Cos(Time.time / offset[0]), 2 * Mathf.Sin(Time.time / offset[0]) + offset[1], 0);

        //transform.Rotate(new Vector3(0, 0, Time.fixedDeltaTime * offset[0] * 90));
    }
}
