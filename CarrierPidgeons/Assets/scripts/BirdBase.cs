using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBase : MonoBehaviour {
    public float speed;
    public int reliability;
    public bool onquest;
    public Transform target;
    public int parcel;
    public AudioClip cooAudioClip;
    bool played = false;
    public int delivermorale;
    Transform coop;

	// Use this for initialization
	void Start () {
        onquest = false;
        coop = transform.parent;
	}
	
	// Update is called once per frame
	void Update () {
        delivermorale = 0;
        Vector3 epsilon = new Vector3(1,1,1);
        if(onquest){
            if (played == false)
            {
                SoundSystem.Instance.Play(cooAudioClip);
                played = true;
            }
            transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed);
            epsilon = transform.position - target.position;
        }
        if(epsilon.magnitude < 0.1){
            print("done");
            onquest = false;
            played = false;
            parcel = -1;
            Destroy(transform.GetChild(0).gameObject);
            transform.position = coop.position;
            delivermorale = 5;
        }
	}
}
