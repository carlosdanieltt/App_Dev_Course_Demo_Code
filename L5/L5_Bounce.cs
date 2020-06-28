using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5_Bounce : MonoBehaviour
{
    public GameObject box;
    Vector2 currentDirection;

    void Start()
    {
        currentDirection = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
    }

    void FixedUpdate()
    {
        float boxWidth = box.GetComponent<L5_Box>().boxWidth;
        float boxHeight = box.GetComponent<L5_Box>().boxHeight;

        if (transform.position.x < -boxWidth / 2.0f | transform.position.x > boxWidth / 2.0f)
        {
            currentDirection.x = -currentDirection.x;
        }

        if (transform.position.y < -boxHeight / 2.0f | transform.position.y > boxHeight / 2.0f)
        {
            currentDirection.y = -currentDirection.y;
        }

        transform.Translate(currentDirection * 0.2f);
    }
}
