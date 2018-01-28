using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoraleTicker : MonoBehaviour {

    public int baseMorale = 100;
    public int morale;
    public Text gameMorale;
    int moralemodifier = 0;
    // Use this for initialization
    void Start () {

        morale = baseMorale;
		
	}
	
	// Update is called once per frame
	void Update () {
        gameMorale.text = morale.ToString()+"%";
        moralemodifier = GameObject.Find("pidgeon").GetComponent<BirdBase>().delivermorale;
        moralemodifier += GameObject.Find("fastpidgeon").GetComponent<BirdBase>().delivermorale;
        moralemodifier += GameObject.Find("fatpidgeon").GetComponent<BirdBase>().delivermorale;
        morale += moralemodifier;
        moralemodifier = 0;
    }
}
