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
    public GameObject PanelIntroFotoRagni;
    public GameObject PanelFotoRagni01;
    public GameObject PanelFotoRagni02;
    public GameObject PanelFotoRagni03;
    public GameObject PanelFotoRagni04;
    public GameObject PanelFotoRagni05;
    public GameObject PanelFotoRagni06;
    public GameObject PanelFotoRagni07;
    public GameObject PanelFotoRagni08;
    public GameObject PanelFotoRagni09;
    public GameObject PanelFotoRagni10;
    public GameObject PanelFotoRagni11;

    public GameObject PanelSospendiFotoRagni;

    public ArrayList arrayPanels = new ArrayList();

    int indexArrayPanel;
    


    // Use this for initialization
    void Start () {
        indexArrayPanel = 0;
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
        arrayPanels.Add(PanelIntroFotoRagni);
        arrayPanels.Add(PanelFotoRagni01);
        arrayPanels.Add(PanelFotoRagni02);
        arrayPanels.Add(PanelFotoRagni03);
        arrayPanels.Add(PanelFotoRagni04);
        arrayPanels.Add(PanelFotoRagni05);
        arrayPanels.Add(PanelFotoRagni06);
        arrayPanels.Add(PanelFotoRagni07);
        arrayPanels.Add(PanelFotoRagni08);
        arrayPanels.Add(PanelFotoRagni09);
        arrayPanels.Add(PanelFotoRagni10);
        arrayPanels.Add(PanelFotoRagni11);
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


    public void ExitPhotosButton()
    {
        for (int i = 0; i < arrayPanels.Count; i++)
        {
            if (((GameObject)arrayPanels[i]).activeSelf)
            {
                indexArrayPanel = i;
                ((GameObject)arrayPanels[i]).SetActive(false);
                PanelSospendiFotoRagni.SetActive(true);
                break;
            }
        }
    }


    public void ResumePhotoButton()
    {
        PanelSospendiFotoRagni.SetActive(false);
        ((GameObject)arrayPanels[indexArrayPanel]).SetActive(true);
    }


    public void ShutDownButton()
    {
        PanelSospendiFotoRagni.SetActive(false);
    }


}
