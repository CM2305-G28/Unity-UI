using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextManager : MonoBehaviour
{
    
    public Text nameText;
    public Text infoText;


    public void displayText(InfoText text)
    {
        nameText.text = text.name;
        infoText.text = text.infotext;
    }


}
