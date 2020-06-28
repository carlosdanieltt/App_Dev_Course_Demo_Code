using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5_Box : MonoBehaviour
{
    public float boxHeight;
    public float boxWidth;

    void FixedUpdate()
    {
        transform.localScale = new Vector3(boxWidth / 4.0f, boxHeight / 4.0f, 0);
    }
}
