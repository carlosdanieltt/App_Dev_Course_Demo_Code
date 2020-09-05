using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class L6_Buttons : MonoBehaviour
{
    public Button button;

    int clickCount;

    // Start is called before the first frame update
    void Start()
    {
        //button.GetComponent<Text>().text = "Here!";

        button.GetComponentInChildren<Text>().text = "Here!";

        button.onClick.AddListener(Click);
    }

    void Click()
    {
        print("Clicked!");

        //clickCount++;
        //button.GetComponentInChildren<Text>().text = "ClickCount: " + clickCount;
    }
}
