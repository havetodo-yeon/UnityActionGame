using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostionExample : MonoBehaviour
{
    public bool isUse = false;
    public float cooltime = 10.0f;
    public float cooltime_max = 10.0f;

    public void OnpotionDown()
    {
        if(isUse == false)
        {
            Debug.Log("Using Potion!");
            StartCoroutine(CooltimeCheck());
        }
    }

    IEnumerator CooltimeCheck()
    {
        while (cooltime > 0.0f)
        {
            GetComponent<Image>().color = Color.black;
            isUse = true;

            cooltime -= Time.deltaTime;
            GetComponent<Image>().fillAmount = cooltime / cooltime_max;

            yield return null;
        }

        Debug.Log("CoolTime Check");
        GetComponent<Image>().color = Color.white;
        GetComponent<Image>().fillAmount = 1.0f;
        cooltime = cooltime_max;
        isUse = false;
    }
}
