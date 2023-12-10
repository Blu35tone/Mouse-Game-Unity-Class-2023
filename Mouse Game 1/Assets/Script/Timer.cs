using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public Text TimerText;
    public Text Results;

    int Woo;

    public Clickforpoint Check;

    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        Woo = Check.Score;
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
                
            }
            else
            {
                Debug.Log("Time is UP");
                TimerText.text = "TIME IS UP";
                TimeLeft = 0;
                TimerOn = false;

                if (Woo > 50)
                {
                    Results.text = "You Won";
                }

                else
                {
                    Results.text = "OOF you Lost";
                }
            }

        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
