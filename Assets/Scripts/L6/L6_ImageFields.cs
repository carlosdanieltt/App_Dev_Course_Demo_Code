using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L6_ImageFields : MonoBehaviour
{
    public Image image;
    public InputField inputField;

    public Button button;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        image.color = Color.red;
        inputField.text = "Hi!";

        button.onClick.AddListener(Click);
    }

    // Update is called once per frame
    void Update()
    {
        //image.color = Color.Lerp(Color.red, Color.green, Time.time % 1.0f);
    }

    void Click()
    {
        image.color = Color.cyan;
        inputField.text = Time.time.ToString("F3");

        text.text = inputField.text;
    }
}
