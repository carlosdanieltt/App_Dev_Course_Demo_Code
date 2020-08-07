using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class User
{
    string name;
    string email;
    string username;

    public User(string name, string email, string username)
    {
        this.name = name;
        this.email = email;
        this.username = username;
    }

    public string getString()
    {
        return "User: [ name: " + name + ", email: " + email + ", username: " + username + " ]";
    }
}
