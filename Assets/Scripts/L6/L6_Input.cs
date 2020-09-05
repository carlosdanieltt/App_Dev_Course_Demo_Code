using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L6_Input : MonoBehaviour
{
    public GameObject sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite.transform.position = new Vector3(0, 0, 0);
    }

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        sprite.transform.Translate(direction);

        //sprite.transform.Translate(direction, Space.World);

        //if (Input.GetKey(KeyCode.R))
        //{
        //    sprite.transform.position = new Vector3(0, 0, 0);
        //    sprite.transform.eulerAngles = new Vector3(0, 0, 0);
        //}

        //if (Input.GetKey(KeyCode.Q))
        //{
        //    sprite.transform.Rotate(new Vector3(0, 0, Time.fixedDeltaTime * 90));
        //}

        //if (Input.GetKey(KeyCode.E))
        //{
        //    sprite.transform.Rotate(new Vector3(0, 0, -Time.fixedDeltaTime * 90));
        //}
    }
}
