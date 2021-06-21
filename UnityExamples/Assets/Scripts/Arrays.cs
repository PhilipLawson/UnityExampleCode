using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Create an array of GameObjects
    [SerializeField] private GameObject[] objs;
    private int objCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        getObjNames(objs);
    }

    void getObjNames(GameObject[] objsToUse)
    {
        foreach (var item in objsToUse)
        {
            // Write the names to the console
            Debug.Log("GameObject #" + objCount + " is:- " + item.name);
            objCount++;
        }
        Debug.Log("There were " + objs.Length + " objects in the array.");
    }
}
