using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public Image image;

    public void StartFadeIn()
    {
        StartCoroutine("Fade");
    }

    public void Start()
    {
        StartFadeIn();
    }

    IEnumerator Fade()
    {
        float startAlpha = 255;
        while(startAlpha > 1.0f)
        {
            startAlpha -= 0.01f;
            yield return new WaitForSeconds(0.01f);
            image.color = new Color(0, 0, 0, startAlpha);
        }
    }

}
