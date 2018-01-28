using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	void OnMouseUp () {
        Debug.Log("clicked");
        SceneManager.LoadScene(1);
	}
	
}
