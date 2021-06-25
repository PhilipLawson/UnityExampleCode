using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RingsCounter : MonoBehaviour
{
    public int ringCount = 0;
    [SerializeField] private TextMeshProUGUI textBox;
    private string ringsText = "Rings: ";

    public void UpdateCounterText()
    {
        textBox.text = ringsText + ringCount.ToString();
    }
}
