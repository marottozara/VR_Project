using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TvCanvas : MonoBehaviour {

	public GameObject PanelIntroduzione;
    public GameObject PanelInizioDomande;
    public GameObject PanelDomanda1;
    public GameObject PanelRisposta1;
    public GameObject PanelDomanda2;
    public GameObject PanelRisposta2;
    public GameObject PanelDomanda3;
    public GameObject PanelRisposta3;
    public GameObject PanelDomanda4;
    public GameObject PanelRisposta4;

    public ArrayList arrayPanels = new ArrayList();
    


    // Use this for initialization
    void Start () {
        arrayPanels.Add(PanelIntroduzione);
        arrayPanels.Add(PanelInizioDomande);
        arrayPanels.Add(PanelDomanda1);
        arrayPanels.Add(PanelRisposta1);
        arrayPanels.Add(PanelDomanda2);
        arrayPanels.Add(PanelRisposta2);
        arrayPanels.Add(PanelDomanda3);
        arrayPanels.Add(PanelRisposta3);
        arrayPanels.Add(PanelDomanda4);
        arrayPanels.Add(PanelRisposta4);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


	public void NextButton()
	{
        for (int i = 0; i < arrayPanels.Count; i++) {
            if (((GameObject)arrayPanels[i]).activeSelf) {
                ((GameObject)arrayPanels[i]).SetActive(false);
                ((GameObject)arrayPanels[i+1]).SetActive(true);
                break;
            }
        }
        
        /*PanelIntroduzione.SetActive (false);
        PanelInizioDomande.SetActive(true);*/
    }

    public void BackButton()
    {
        for (int i = 0; i < arrayPanels.Count; i++)
        {
            if (((GameObject)arrayPanels[i]).activeSelf)
            {
                ((GameObject)arrayPanels[i]).SetActive(false);
                ((GameObject)arrayPanels[i - 1]).SetActive(true);
                break;
            }
        }
    }


}
