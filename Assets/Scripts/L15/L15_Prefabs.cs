using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L15_Prefabs : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject object1 = Instantiate(prefab);
        object1.transform.position = new Vector3(2, 3, 0);
        object1.transform.eulerAngles = new Vector3(0, 0, 32);
        object1.transform.localScale = new Vector3(1.2f, 0.6f, 1);

        GameObject object2 = Instantiate(prefab);
        object2.transform.position = new Vector3(-2, -3, 0);
        object2.transform.eulerAngles = new Vector3(0, 0, 12);
        object2.transform.localScale = new Vector3(0.4f, 2.1f, 1);
    }
}
