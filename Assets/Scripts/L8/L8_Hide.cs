using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L8_Hide : MonoBehaviour
{
    public Button firstHideButton;
    public Button secondHideButton;
    public Text hideText;

    // Start is called before the first frame update
    void Start()
    {
        firstHideButton.onClick.AddListener(Hide1);
        secondHideButton.onClick.AddListener(Hide2);
    }

    void Hide1()
    {
        print("Hide 1 Clicked!");

        hideText.text = "Hidden!";

        hideText.gameObject.SetActive(false);
    }

    void Hide2()
    {
        print("Hide 2 Clicked!");

        hideText.text = "Hidden!";

        if (hideText.gameObject.activeSelf)
        {
            hideText.gameObject.SetActive(false);
        }
        else
        {
            hideText.gameObject.SetActive(true);
        }

        //hideText.gameObject.SetActive(!hideText.gameObject.activeSelf);
    }
}
