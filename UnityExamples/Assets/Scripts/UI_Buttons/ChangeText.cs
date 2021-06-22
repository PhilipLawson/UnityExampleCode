using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textBox;
    
    public void buttonOneText()
    {
        textBox.text = "This is the text for button 1 - Placing this string into the Text objects.text value.";
    }

    public void buttonTwoText()
    {
        textBox.text = "This is the text for button 2 - It does the same as button 1, however the text string is not the same.";
    }
}
