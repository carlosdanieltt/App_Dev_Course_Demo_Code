using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5_UpdateMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Start!");
    }

    // Update is called once per frame
    void Update()
    {
        //print("Update!");
    }

    void FixedUpdate()
    {
        //print(Time.time);
        //print(Time.fixedDeltaTime);

        //transform.position = new Vector3(2, Time.time, 0);

        //transform.position = new Vector3(2, getSine(Time.time), 0);

        //transform.position = new Vector3(getCosine(Time.time), getSine(Time.time), 0);

        //transform.Translate(new Vector3(0, Time.fixedDeltaTime, 0));

        //transform.eulerAngles = new Vector3(0, 0, Time.time * 90);

        //transform.eulerAngles = new Vector3(0, 0, getSine(Time.time) * 90);

        //transform.Rotate(new Vector3(0, 0, -Time.fixedDeltaTime * 90));

        //transform.Rotate(new Vector3(Time.fixedDeltaTime * 45, Time.fixedDeltaTime * 90, -Time.fixedDeltaTime * 90));

        //transform.localScale = new Vector3(Time.time * 0.5f, Time.time * 0.5f, 1);

        //transform.localScale = new Vector3(getSine(Time.time), getCosine(Time.time), 1);
    }

    float getSine(float time)
    {
        return Mathf.Sin(time);
    }

    float getCosine(float time)
    {
        return Mathf.Cos(time);
    }
}
