using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageController : MonoBehaviour
{
    #region Field
    public int StagePoint = 0;
    public Text PointText;
    #endregion

    #region Singleton
    public static StageController Instance;

    private void Start()
    {
        Instance = this;
        DialogDataAlert alert = new DialogDataAlert("START", "Game Start!", 
            delegate () { Debug.Log("OK Pressed!"); });
        DialogManager.Instance.Push(alert);
    }
    #endregion

    public void AddPoint(int Point)
    {
        StagePoint += Point;
        PointText.text = StagePoint.ToString();
    }

    public void FinishGame()
    {
        DialogDataConfirm confirm = new DialogDataConfirm("Restart", "Please press OK if you want to restart the game.",
            delegate (bool yn)
            {
                if(yn)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
                else
                {
                    Application.Quit();
                }
            });
        DialogManager.Instance.Push(confirm);
    }


}
