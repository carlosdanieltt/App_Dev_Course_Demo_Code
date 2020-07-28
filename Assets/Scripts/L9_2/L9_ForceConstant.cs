using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L9_ForceConstant : MonoBehaviour
{
    Rigidbody rigidbody;

    public float moveMagnitude;
    public float rotateMagnitude;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(new Vector3(moveMagnitude, 0, 0));

        rigidbody.AddTorque(new Vector3(0, 0, rotateMagnitude));
    }
}
