using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasAcrofobiaPause : MonoBehaviour {

    string sceneToLoad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void ContinueButton()
    {
        sceneToLoad = PlayerPrefs.GetString("loadScene");
        SceneManager.LoadScene(sceneToLoad);
    }


    public void ShutdownButton()
    {
        SceneManager.LoadScene("Home");
    }
}
