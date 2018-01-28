using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    public int hourlength;
    public int pauselength;
    public int evntprcnt;
    int timer = 0;
    public int hour = 0;
    int day = 1;
    int trigger = 0;
    int pausetrigger = 0;
    public Text gameTime;
    public Text eventAlert;
    bool paused = false;
    int evnt;
    Random random = new Random();

    // Use this for initialization
    void Start () {
        trigger = hour - 1;
        evnt = 0;
    }

// Update is called once per frame
void Update () {
        gameTime.text = "Day: "+day+" Hour: "+hour.ToString();
        eventAlert.text = hour.ToString() + "   " + trigger.ToString();
        /*
        if ((trigger != hour) && (paused == false))
        {
            if (Random.Range(0,100) <= evntprcnt)
            {
                evnt++;
                paused = true;
            }

            trigger++;
        }
        
        if (evnt == 1)
        {
            eventAlert.text = "Event Triggered!";
        }
        
        if (paused == true)
        {
            pausetrigger++;
            if(pausetrigger==pauselength)
            {
                paused = false;
                evnt--;
                pausetrigger = 0;
            }

    }
    */
        if (paused == false)
        {
            timer++;
        }
        if (timer==hourlength)
        {
            hour++;
            timer = 0;
        }
        if(hour==24)
        {
            day++;
            hour = 0;
            trigger = hour - 1;
        }



    }
}

