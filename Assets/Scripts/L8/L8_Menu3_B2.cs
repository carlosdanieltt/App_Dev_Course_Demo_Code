using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L8_Menu3_B2 : MonoBehaviour
{
    public Text hiddenText;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ToggleText);
    }

    void ToggleText()
    {
        hiddenText.gameObject.SetActive(!hiddenText.gameObject.activeSelf);

        GetComponent<Button>().GetComponentInChildren<Text>().text = hiddenText.gameObject.activeSelf ? "Hide" : "Show";
    }
}
