
using UnityEngine;
using UnityEngine.UI;

public class togglebird : MonoBehaviour {
    public Sprite[] birds;
    public string[] names;
    public Text currentname;
    public int currentbird;
    int totalbirds;
	// Use this for initialization
	void Start () {
        currentbird = 0;
        totalbirds = 3;
	}
	
	// Update is called once per frame
	void Update () {
        //print(currentbird);
        GetComponent<Image>().sprite = birds[currentbird];
        currentname.text = names[currentbird];
	}

    public void ForwardToggle(){
        int temp = currentbird + 1;
        currentbird = temp % totalbirds;
    }
}
