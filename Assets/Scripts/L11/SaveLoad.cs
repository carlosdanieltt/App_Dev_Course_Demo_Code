using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveLoad
{
    public static HashSet<User> savedUsers = new HashSet<User>();

    public static void Save(User savedUser)
    {
        SaveLoad.savedUsers.Add(savedUser);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/savedUsers.save");
        bf.Serialize(file, SaveLoad.savedUsers);
        file.Close();
    }

    public static void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/savedUsers.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/savedUsers.save", FileMode.Open);
            SaveLoad.savedUsers = (HashSet<User>)bf.Deserialize(file);
            file.Close();
        }
    }
}