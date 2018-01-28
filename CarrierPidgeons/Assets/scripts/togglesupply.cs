using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class togglesupply : MonoBehaviour {
    public Sprite[] supplies;
    public string[] names;
    public Text currentname;
    public int currentitem;
    int totalitems;
	// Use this for initialization
	void Start () {
        currentitem = 0;
        totalitems = 6;
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Image>().sprite = supplies[currentitem];
        currentname.text = names[currentitem];
	}

    public void ForwardToggle()
    {
        int temp = currentitem + 1;
        currentitem = temp % totalitems;
    }
}
