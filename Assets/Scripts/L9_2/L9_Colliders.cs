using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L9_Colliders : MonoBehaviour
{
    public GameObject other;

    void Start()
    {
        other.GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        print("Entered!");

        //if (other.gameObject.tag == "Valid")
        //{
        //    print("Valid!");
        //}
    }

    void OnTriggerStay2D(Collider2D other)
    {
        print("Inside!");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        print("Exited!");
    }
}
