using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class Event100th
{
    public event EventHandler user100;

    public void PlayGame()
    {
        if(user100 != null)
        {
            user100(this, EventArgs.Empty);
        }
    }

}

public class UnityEventExample1 : MonoBehaviour
{
    public Text eventText;
    Event100th event100th;
    string eventAlert;

    // Start is called before the first frame update
    void Start()
    {
        eventAlert = "�����մϴ�! 100��° ���� �����Դϴ�!\r\n�̺�Ʈ�� ��÷�Ǽ̽��ϴ�!";
        
        event100th = new Event100th();
        event100th.user100 += new EventHandler(EnterGame);
        event100th.PlayGame();
    }

    private void EnterGame(object sender, EventArgs e)
    {
        StartCoroutine(Typing(eventAlert));

        IEnumerator Typing(string eventAlert)
        {
            eventText.text = null;

            for(int i = 0; i < eventAlert.Length; i++)
            {
                eventText.text += eventAlert[i];
                yield return new WaitForSeconds(0.05f);
            }
        }
    }

}
