using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car
{
    string make;
    string model;
    int year;
    Texture image;

    public Car(string make, string model, int year, Texture image)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.image = image;
    }

    public string getMake()
    {
        return make;
    }

    public string getModel()
    {
        return model;
    }

    public int getYear()
    {
        return year;
    }

    public Texture getImage()
    {
        return image;
    }
}
