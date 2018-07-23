using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TvCanvasCityHome : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void NextButton()
    {
        SceneManager.LoadScene("City");
    }


    public void ExitButton()
    {

    }
}
