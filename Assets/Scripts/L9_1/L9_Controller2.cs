using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L9_Controller2 : MonoBehaviour
{
    public Text makeText;
    public Text modelText;
    public Text yearText;
    public RawImage imageSlot;

    public Button nextButton;
    public Button previousButton;

    List<Car> cars;
    int currentCar = 0;

    // Start is called before the first frame update
    void Start()
    {
        cars = new List<Car>
        {
            new Car("Honda", "Civic", 2014, Resources.Load("civic") as Texture),
            new Car("Jeep", "Renegade", 2018, Resources.Load("jeep") as Texture),
            new Car("Tesla", "Model 3", 2020, Resources.Load("tesla") as Texture)
        };

        nextButton.onClick.AddListener(Next);
        previousButton.onClick.AddListener(Previous);

        populate(cars[0]);
    }

    void populate(Car car)
    {
        makeText.text = "Make: " + car.getMake();
        modelText.text = "Model: " + car.getModel();
        yearText.text = "Year: " + car.getYear().ToString();
        imageSlot.texture = car.getImage();
    }

    void Next()
    {
        currentCar = (currentCar + 1) % cars.Count;
        populate(cars[currentCar]);
    }

    void Previous()
    {
        currentCar = (currentCar - 1 + cars.Count) % cars.Count;
        populate(cars[currentCar]);
    }
}
