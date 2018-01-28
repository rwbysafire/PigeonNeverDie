using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorialtext : MonoBehaviour {
    string p1;
    string p2;
    string p3;
    int clicks;
    public GameObject parent;
    public GameObject coop;
	// Use this for initialization
	void Start () {
        p1 = "From: Zenaida Oldham \n Oi lad!I know I only said I’d be away for a few minutes but it looks like I’ll be gone for several days. Strange, I know, but dinnae’ worry.Jus’ remember everything I taught ye and ye’ll be fine.";
        p2 = "Select an item to send, a Pigeon, and point to a destination on yer map; then the birds will take care of the rest.";
        p3 = "Now that that’s done ye can get started by sending me some GRUB. I’d sooner eat yer cookin’ than the crap they call rations down on our ALLIANCE FRONTLINE. Dinnae’ matter what bird ye send, just send em’ fast.";
        GetComponent<Text>().text = p1;
        coop.SetActive(false);
	}

    public void nextdialog(){
        clicks++;
        if(clicks == 1){
            GetComponent<Text>().text = p2;
        }
        if(clicks == 2){
            GetComponent<Text>().text = p3;
        }
        if(clicks == 3){
            coop.SetActive(true);
            parent.SetActive(false);
        }
    }


}
