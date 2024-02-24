using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timeupscreen : MonoBehaviour
{
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }


    public void RestartButton() {
        SceneManager.LoadScene("Countdown");
    }

    public void ExitButton() {
        SceneManager.LoadScene("home");
    }
}
