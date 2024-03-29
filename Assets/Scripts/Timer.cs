using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public Slider timerSlider;
    public TextMeshProUGUI timerText;
    public float gameTime;

    private bool stopTimer;

    private void Start()
    {
        stopTimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
    }
    void Update()
    {
        float time = gameTime - Time.time;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        string textTime = string.Format("{0:0}:{1:0}", minutes, seconds);

        if ( time <= 0)
        {
            stopTimer = true;
            SceneManager.LoadScene("perder");
        }

        if ( stopTimer == false)
        {
            timerText.text = textTime;
            timerSlider.value = time;
        }


       
    }
}
