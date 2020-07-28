using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L9_Controller1 : MonoBehaviour
{
    public Text makeText;
    public Text modelText;
    public Text yearText;
    public RawImage imageSlot;

    // Start is called before the first frame update
    void Start()
    {
        Car car = new Car("Honda", "Civic", 2014, Resources.Load("civic") as Texture);

        populate(car);
    }

    void populate(Car car)
    {
        makeText.text = "Make: " + car.getMake();
        modelText.text = "Model: " + car.getModel();
        yearText.text = "Year: " + car.getYear().ToString();
        imageSlot.texture = car.getImage();
    }
}
