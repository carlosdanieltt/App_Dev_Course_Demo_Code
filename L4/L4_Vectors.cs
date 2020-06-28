using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L4_Vectors : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 speed = new Vector2(3.5f, 2.4f);

        print("Speed.x is: " + speed.x);
        print("Speed[0] is: " + speed[0]);
        print("Speed.y is: " + speed.y);

        //Vector3 velocity = new Vector3(3.5f, 2.4f, 2.9f);

        //print("Velocity.x is: " + velocity.x);
        //print("Velocity.y is: " + velocity.y);
        //print("Velocity.z is: " + velocity.z);
        //print("Velocity[1] is: " + velocity[1]);
    }
}
