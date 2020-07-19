using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L8_Menu1 : MonoBehaviour
{
    public Button firstButton;
    public Button secondButton;
    public Text hiddenText;
    public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        firstButton.onClick.AddListener(HideMenu);
        secondButton.onClick.AddListener(ToggleText);
    }

    void HideMenu()
    {
        menu.SetActive(false);
    }

    void ToggleText()
    {
        hiddenText.gameObject.SetActive(!hiddenText.gameObject.activeSelf);

        if (hiddenText.gameObject.activeSelf)
        {
            secondButton.GetComponentInChildren<Text>().text = "Hide";
        }
        else
        {
            secondButton.GetComponentInChildren<Text>().text = "Show";
        }

        //secondButton.GetComponentInChildren<Text>().text = hiddenText.gameObject.activeSelf ? "Hide" : "Show";
    }
}
