using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L11_PlayerPrefs : MonoBehaviour
{
    public InputField inputField;
    public Text displayText;
    public Button saveButton;
    public Button loadButton;
    public Button clearButton;

    // Start is called before the first frame update
    void Start()
    {
        saveButton.onClick.AddListener(Save);
        loadButton.onClick.AddListener(Load);
        clearButton.onClick.AddListener(Clear);
    }

    void Save()
    {
        PlayerPrefs.SetString("TestKey", inputField.text);
    }

    void Load()
    {
        string value = PlayerPrefs.GetString("TestKey", "None");
        displayText.text = value;
    }

    void Clear()
    {
        PlayerPrefs.DeleteAll();
    }
}
