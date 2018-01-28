using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartButton : MonoBehaviour {
    public AudioClip audioClip;
    public AudioSource audioSource;

	// Use this for initialization
	void OnMouseUp () {
        Debug.Log("clicked");
        audioSource.PlayOneShot(audioClip);
        StartCoroutine(LoadSceneAfterSoundFinishes());
	}

    private IEnumerator LoadSceneAfterSoundFinishes()
    {
        while (audioSource.isPlaying)
        {
            yield return new WaitForEndOfFrame();
        }

        SceneManager.LoadScene(1);
    }
	
}
