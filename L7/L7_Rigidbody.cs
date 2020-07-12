using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L7_Rigidbody : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        //button.onClick.AddListener(Click);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(new Vector2(0, 500.0f * Time.fixedDeltaTime));
    }

    void Click()
    {
        //rigidbody.AddForce(new Vector2(0, 500));

        //rigidbody.AddForce(new Vector2(25, 500));
    }
}
