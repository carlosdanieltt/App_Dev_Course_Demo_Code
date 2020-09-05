using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L4_Transform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Object y position: " + transform.position.y);
        print("Object x scale: " + transform.localScale.x);
        print("Object x rotation: " + transform.eulerAngles.x);

        transform.position = new Vector3(2, 2, 0);

        //transform.position = new Vector2(2, 2);

        //transform.localScale = new Vector3(1, 1.5f, 1);

        //transform.eulerAngles = new Vector3(0, 0, 45);
    }
}
