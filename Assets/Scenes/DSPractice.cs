using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DSPractice : MonoBehaviour
{
    public Text OutputName;
    public Text OutputInfo;

    public Text[] Info = new Text[6];

    public string abitity;

    public Dictionary<string, int>[] ItemInfo = new Dictionary<string, int>[6];

    string[] ItemIntroduce = new string[6];

    public void abilityOutput()
    {
        OutputName.text = Info[0].text;
        for (int i = 1; i < Info.Length; i++)
        {
            OutputInfo.text += $"\n : {Info[i].text}";
        }
    }
    public void InfoInput()
    {
        for (int i = 0; i < Info.Length; i++)
        {
            ItemIntroduce[i] = Info[i].text;
        }
    }
}
