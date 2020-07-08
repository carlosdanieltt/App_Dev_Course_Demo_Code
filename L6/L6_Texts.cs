using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class L6_Texts : MonoBehaviour
{
    public Text hiText;

    // Start is called before the first frame update
    void Start()
    {
        hiText.text = "Started!";
    }

    // Update is called once per frame
    void Update()
    {
        //hiText.text = "Time is: " + Time.time;

        //hiText.text = "Time is: " + Time.time.ToString("F3");
    }
}
