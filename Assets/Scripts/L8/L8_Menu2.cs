using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L8_Menu2 : MonoBehaviour
{
    public Button firstButton;
    public GameObject menu1;
    public GameObject menu2;

    // Start is called before the first frame update
    void Start()
    {
        firstButton.onClick.AddListener(GoToMenu1);
    }

    void GoToMenu1()
    {
        menu2.SetActive(false);
        menu1.SetActive(true);
    }
}
