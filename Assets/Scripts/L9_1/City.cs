using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class City : ScriptableObject
{
    public string name;
    public Texture image;

    public City(string name, Texture image)
    {
        this.name = name;
        this.image = image;
    }
}
