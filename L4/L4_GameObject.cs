using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L4_GameObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Active: " + gameObject.activeSelf);
        print("Name: " + gameObject.name);
    }
}
