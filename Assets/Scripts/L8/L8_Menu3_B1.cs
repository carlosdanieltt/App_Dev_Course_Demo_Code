using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L8_Menu3_B1 : MonoBehaviour
{
    public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(HideMenu);
    }

    void HideMenu()
    {
        menu.SetActive(false);
    }
}
