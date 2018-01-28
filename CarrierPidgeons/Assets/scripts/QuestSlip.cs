using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestSlip : MonoBehaviour {
    public float BufferTime;
    public float Timer;
    public float xpos;
    private float countdown;
    private bool startCount;
	// Use this for initialization
	void Start () {
        startCount = false;
        countdown = Timer;
        transform.position = new Vector3(-10, transform.position.y, 0);
	}
	
	// Update is called once per frame
	void Update () {
        BufferTime -= Time.deltaTime;
        if (BufferTime <= 0 && BufferTime > -0.1)
        {            
            transform.position = new Vector3(xpos, transform.position.y, 0);
        }
        if(startCount == true)
        {
            countdown -= Time.deltaTime;
        }
        if (countdown <= 0)
        {
            startCount = false;
            gameObject.transform.position = new Vector3(xpos, transform.position.y, 0);
            countdown = Timer;
        }
	}

    void OnMouseDown()
    {
        Debug.Log("clicked");
        transform.position = new Vector3(-10, transform.position.y, 0);
        startCount = true;
    }


}
