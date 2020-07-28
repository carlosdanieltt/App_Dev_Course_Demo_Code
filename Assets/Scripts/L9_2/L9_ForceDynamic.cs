using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L9_ForceDynamic : MonoBehaviour
{
    Rigidbody ownRigidbody;

    public GameObject otherObject;
    public Vector2 initialVelocity;

    const float gravitonalConstant = 6.674f;

    // Start is called before the first frame update
    void Start()
    {
        ownRigidbody = GetComponent<Rigidbody>();
        ownRigidbody.velocity = initialVelocity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 toOtherObject = otherObject.transform.position - transform.position;
        Vector2 normalizedDirection = toOtherObject / toOtherObject.magnitude;

        float magnitude = (gravitonalConstant * ownRigidbody.mass * otherObject.GetComponent<Rigidbody>().mass) / (Mathf.Pow(toOtherObject.magnitude, 2));

        ownRigidbody.AddForce(normalizedDirection * magnitude);
    }
}
