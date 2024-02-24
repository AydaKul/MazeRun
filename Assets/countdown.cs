using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingtime;

    void Update()
    {
        if (remainingtime > 0)
        {
            remainingtime -= Time.deltaTime;
        }
        else if(remainingtime < 0)
        {
            remainingtime = 0;
            timerText.color = Color.red;
        }
        int minleft = Mathf.FloorToInt(remainingtime / 60);
        int secleft = Mathf.FloorToInt(remainingtime % 60);
        timerText.text = string.Format("{00:00}:{01:00}", minleft, secleft);
    }

    // public void Pause()
    // {
    //     pauseMenu.SetActive(true);
    //     Time.timeScale = 0;
    // }

    // public void Resume()
    //     {
    //         pauseMenu.SetActive(false);
    //         Time.timeScale = 1;
    //     }

}