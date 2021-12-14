using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelBreak : MonoBehaviour
{

    [SerializeField] private GameObject[] GlassPanels;
    Dictionary<GameObject, int> panelDetails = new Dictionary<GameObject, int>();
    private int iCount = 0;
    private int lastValue;

    private int myValue;
    // Start is called before the first frame update
    void Start()
    {
        sortGlass();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void sortGlass()
    {

        foreach(GameObject panel in GlassPanels)
        {
            if (iCount == 0)
            {
                myValue = Random.Range(0,2);
                panelDetails.Add(panel, myValue);
                lastValue = myValue;
                iCount++;
            }
            else
            {
                iCount = 0;
                if (lastValue == 0)
                {
                   panelDetails.Add(panel, 1); 
                }
                else
                {
                    panelDetails.Add(panel, 0); 
                }
            }
        }

        foreach (KeyValuePair<GameObject, int> kvp in panelDetails)
        {
            Debug.Log(kvp.Key + " " + kvp.Value);
            if (kvp.Value == 0)
            {
                kvp.Key.gameObject.tag = "Enemy";
            }
        }
    }
}
