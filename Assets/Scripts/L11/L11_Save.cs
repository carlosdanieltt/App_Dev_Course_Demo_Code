using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L11_Save : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        User user1 = new User("James", "james@gmail.com", "james435");
        User user2 = new User("Peter", "peter@yahoo.com", "peter39");
        User user3 = new User("Jack", "jack45@gmail.com", "jack2");
        print(user1.ToString());
        print(user1.getString());

        //SaveLoad.Save(user1);
        //SaveLoad.Save(user2);
        //SaveLoad.Save(user3);
    }

    //// Start is called before the first frame update
    //void Start()
    //{
    //    SaveLoad.Load();

    //    foreach (User user in SaveLoad.savedUsers)
    //    {
    //        print(user.getString());
    //    }
    //}
}
