using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Arrays : MonoBehaviour
{
    // Create an array of GameObjects
    [SerializeField] private GameObject[] objs;
    [SerializeField] private TextMeshProUGUI[] TextBoxes;
    private int objCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        getObjNames(objs);
    }

    void getObjNames(GameObject[] objsToUse)
    {
        foreach (var item in objsToUse)
        {
            // Write the names to the text
            TextBoxes[objCount].text = item.name;
            objCount++;
        }
        Debug.Log("There were " + (objs.Length + 1) + " objects in the array.");
    }
}
