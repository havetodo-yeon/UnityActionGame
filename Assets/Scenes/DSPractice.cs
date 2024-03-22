using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DSPractice : MonoBehaviour
{
    public Text OutputName;
    public Text OutputInfo;

    public string abitity;
    public Text inputText;
    public Text inputName;

    public Text[] Info = new Text[6];
    public Dictionary<string, int>[] ItemInfo = new Dictionary<string, int>[6];

    string[] ItemIntroduce = new string[6];

    public void abilityOutput()
    {
        OutputName.text = inputName.text;
        OutputInfo.text += $"\n{abitity} : {inputText.text}";
    }
    public void InfoInput()
    {
        for (int i = 0; i < Info.Length; i++)
        {
            ItemIntroduce[i] = Info[i].text;
        }
    }
}
