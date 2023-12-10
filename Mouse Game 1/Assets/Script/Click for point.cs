using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Clickforpoint : MonoBehaviour
{
    //variables for the game

    public int Score;
    public Text scoreText;

    bool Tiempo;
    public Timer YayorNay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Tiempo = YayorNay.TimerOn;

        if (Input.GetMouseButtonDown(0) && Tiempo)
        {
            Score++;
        }

        scoreText.text = Score.ToString();
    }
}
