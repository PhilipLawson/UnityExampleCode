using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelBreak : MonoBehaviour
{

    [SerializeField] private GameObject[] GlassPanels;
    Dictionary<GameObject, int> panelDetails = new Dictionary<GameObject, int>();
    private int iCount = 0;
    private int dictCount = 0;
    private int lastValue;
    // Start is called before the first frame update
    void Start()
    {
        sortGlass(dictCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void sortGlass(int dictCount)
    {
        //This is how you create a list.
        List<int> randNum = new List<int>();
        
        //Here you add 2 values
        randNum.Add(0);
        randNum.Add(1);

        foreach(GameObject panel in GlassPanels)
        {
            if (iCount < 1)
            {
                int myValue = Random.Range(0,1);
                panelDetails.Add(panel, myValue);
                lastValue = myValue;
                iCount++;
            }
            else
            {
                iCount = 0;
                int myValue = Random.Range(0,1);
                panelDetails.Add(panel, myValue);
                panelDetails.TryGetValue(panel,out int returnedValue);
            dictCount++;
            }
        }
    }
}
