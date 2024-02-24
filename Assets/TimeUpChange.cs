using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 20;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        { // Time's up - transition to the "Time Up" scene
            UnityEngine.SceneManagement.SceneManager.LoadScene("TimeUpScene");
            Time.timeScale = 0f;
        }
    }
}
