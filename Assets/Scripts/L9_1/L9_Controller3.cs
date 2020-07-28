using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L9_Controller3 : MonoBehaviour
{
    public Text nameText;
    public RawImage imageSlot;

    public Button nextButton;
    public Button previousButton;

    List<City> cities;
    int currentCity = 0;

    public City berlin;
    public City london;

    // Start is called before the first frame update
    void Start()
    {
        cities = new List<City>
        {
            berlin,
            london,
            new City("Tokyo", Resources.Load("tokyo") as Texture)
        };

        nextButton.onClick.AddListener(Next);
        previousButton.onClick.AddListener(Previous);

        populate(cities[0]);
    }

    void populate(City city)
    {
        nameText.text = "Name: " + city.name;
        imageSlot.texture = city.image;
    }

    void Next()
    {
        currentCity = (currentCity + 1) % cities.Count;
        populate(cities[currentCity]);
    }

    void Previous()
    {
        currentCity = (currentCity - 1 + cities.Count) % cities.Count;
        populate(cities[currentCity]);
    }
}
