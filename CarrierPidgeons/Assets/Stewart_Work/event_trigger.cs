using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class event_trigger : MonoBehaviour {
    int time = GameObject.Find("Timer").GetComponent<TimerScript>().hour;
    int trigger = 0;
    public Text eventAlert;
    Random random = new Random();
    // Use this for initialization

    void Start ()
    {
        trigger = time-1;

	}
	
	// Update is called once per frame
	void Update () {
        time = GameObject.Find("Timer").GetComponent<TimerScript>().hour;
        eventAlert.text = time.ToString()+"   "+trigger.ToString();
        if (trigger!=time)
        {
            if(Random.Range(0, 100)<=10)
            {
                eventAlert.text = "Event Triggered!";
            }

            trigger++;
        }
		
	}
}
