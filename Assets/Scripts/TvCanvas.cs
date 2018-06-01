using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TvCanvas : MonoBehaviour {

	public GameObject thisCanvas01;
    public Image BackgroundImage;
    public Color NormalColor;
    public Color HighlightColor;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void NextPage()
	{
		thisCanvas01.SetActive (false);
    }


    public void OnGazeEnter()
    {
        BackgroundImage.color = HighlightColor;
    }


    public void OnGazeExit()
    {
        BackgroundImage.color = NormalColor;
    }
}
