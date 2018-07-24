using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TvCanvasCity : MonoBehaviour {

    string currentScene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void NextButton()
    {
        SceneManager.LoadScene("Mountain");
    }


    public void ExitButton()
    {
        currentScene = SceneManager.GetActiveScene().name.ToString(); //viene salvato il nome della scena da caricare
        PlayerPrefs.SetString("loadScene", currentScene);
        SceneManager.LoadScene("AcrofobiaPause");
    }


    public void BackButton()
    {
        SceneManager.LoadScene("CityHome");
    }
}
