using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

    
    public Text timerHours;
    public Text timerMinutes;
    public Text timerSeconds;
    public Text timerSeconds100;

    private float startTime;
    private float stopTime;
    private float timerTime;
    private bool isRunning = false;

	// Use this for initialization
	void Start () {
        TimerReset();
    }

    public void TimerStart() {
        if (!isRunning) {
            print("START");
            isRunning = true;
            startTime = Time.time;       
        }
    }

    public void TimerStop()
    {
        if (isRunning)
        {
            print("STOP");
            isRunning = false;
            stopTime = timerTime;
        }
    }

    public void TimerReset()
    {
        print("RESET");
        stopTime = 0;
        isRunning = false;
        timerHours.text = timerMinutes.text = timerSeconds.text = timerSeconds100.text = "00";
    }

    // Update is called once per frame
    void Update () {
        timerTime = stopTime + (Time.time - startTime);
        int hoursInt = (int)(Mathf.Floor((timerTime % 216000) / 3600));
        int minutesInt = (int)(Mathf.Floor((timerTime % 3600) / 60));
        int secondsInt = (int)((timerTime % 60));
        int seconds100Int = (int)(Mathf.Floor((timerTime - (secondsInt + minutesInt * 60)) * 100));

        if (isRunning)
        {
            timerHours.text = (hoursInt < 10) ? "0" + hoursInt : hoursInt.ToString();
            timerMinutes.text = (minutesInt < 10) ? "0" + minutesInt : minutesInt.ToString();
            timerSeconds.text = (secondsInt < 10) ? "0" + secondsInt : secondsInt.ToString();
            timerSeconds100.text = (seconds100Int < 10) ? "0" + seconds100Int : seconds100Int.ToString();
        }
    }
}