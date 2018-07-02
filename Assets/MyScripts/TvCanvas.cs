﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TvCanvas : MonoBehaviour {

    string panelName;

    bool interactionWithSpiders;

    public GameObject Books;
    public GameObject Theca;
    public GameObject smallSpider;
    public GameObject mediumSpider;
    public GameObject bigSpider;

    public GameObject mediumSpiderIdle;

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
    public GameObject PanelIntroInterazioneRagni;
    public GameObject PanelInterazioneRagniTasti;

    public GameObject PanelSospendiFotoRagni;
    public GameObject PanelSospendiInterazioneRagni;
    public GameObject PanelCompletamentoPercorsoRagni;

    public ArrayList arrayPanels = new ArrayList();

    int indexArrayPanel;
    int stepSpiders;
    bool changeSpiderPosition;
    bool putSpiderInTheca;


    // Use this for initialization
    void Start () {

        panelName = "";

        interactionWithSpiders = true;
        changeSpiderPosition = true;
        putSpiderInTheca = false;

        Books.SetActive(true);
        Theca.SetActive(false);
        smallSpider.SetActive(false);
        mediumSpider.SetActive(false);
        bigSpider.SetActive(false);
        mediumSpiderIdle.SetActive(false);

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
        arrayPanels.Add(PanelIntroInterazioneRagni);
        arrayPanels.Add(PanelInterazioneRagniTasti);

        stepSpiders = 1;
    }

    // Update is called once per frame
    void Update () {

        for (int i = 0; i < arrayPanels.Count; i++)
        {
            
            if (((GameObject)arrayPanels[i]).activeSelf)
            {
                panelName = ((GameObject)arrayPanels[i]).name.ToString();

                switch (panelName)
                {
                    case "PanelIntroInterazioneRagni":
                        Books.SetActive(false);
                        Theca.SetActive(true);
                        break;

                    case "PanelInterazioneRagniTasti":
                        switch (stepSpiders)
                        {
                            case 0:
                                Theca.SetActive(true);
                                smallSpider.SetActive(false);
                                mediumSpider.SetActive(false);
                                bigSpider.SetActive(false);
                                mediumSpiderIdle.SetActive(false);
                                break;
                            case 1:
                                Theca.SetActive(true);
                                smallSpider.SetActive(true);
                                mediumSpider.SetActive(false);
                                bigSpider.SetActive(false);
                                mediumSpiderIdle.SetActive(false);
                                break;
                            case 2:
                                Theca.SetActive(true);
                                smallSpider.SetActive(true);
                                mediumSpider.SetActive(true);
                                bigSpider.SetActive(false);
                                mediumSpiderIdle.SetActive(false);
                                break;
                            case 3:
                                Theca.SetActive(true);
                                if(putSpiderInTheca == true)
                                {
                                    smallSpider.transform.position = new Vector3(3f, 0.887f, 4.06f);
                                    mediumSpider.transform.position = new Vector3(3.469f, 0.858f, 3.83f);
                                    bigSpider.transform.position = new Vector3(3.213f, 0.859f, 3.978f);
                                    putSpiderInTheca = false;
                                }
                                smallSpider.SetActive(true);
                                mediumSpider.SetActive(true);
                                bigSpider.SetActive(true);
                                mediumSpiderIdle.SetActive(false);
                                break;
                            case 4:
                                Theca.SetActive(false);
                                if(changeSpiderPosition == true)
                                {
                                    smallSpider.transform.position = new Vector3(2.599f, 0.8427f, 4.06f);
                                    smallSpider.transform.rotation = new Quaternion(0f, 180f, 0f, 1);
                                    changeSpiderPosition = false;
                                }
                                smallSpider.SetActive(true);
                                mediumSpider.SetActive(false);
                                bigSpider.SetActive(false);
                                mediumSpiderIdle.SetActive(false);
                                break;
                            case 5:
                                Theca.SetActive(false);
                                if (changeSpiderPosition == true)
                                {
                                    smallSpider.transform.position = new Vector3(2.599f, 0.8427f, 4.06f);
                                    smallSpider.transform.rotation = new Quaternion(0f, 180f, 0f, 1);
                                    mediumSpider.transform.position = new Vector3(2.975f, 0.842f, 3.757f);
                                    mediumSpider.transform.rotation = new Quaternion(0f, 180f, 0f, 1);
                                    changeSpiderPosition = false;
                                }
                                smallSpider.SetActive(true);
                                mediumSpider.SetActive(true);
                                bigSpider.SetActive(false);
                                mediumSpiderIdle.SetActive(false);
                                break;
                            case 6:
                                Theca.SetActive(false);
                                if (changeSpiderPosition == true)
                                {
                                    smallSpider.transform.position = new Vector3(2.599f, 0.8427f, 4.06f);
                                    smallSpider.transform.rotation = new Quaternion(0f, 180f, 0f, 1);
                                    mediumSpider.transform.position = new Vector3(2.975f, 0.842f, 3.757f);
                                    mediumSpider.transform.rotation = new Quaternion(0f, 180f, 0f, 1);
                                    bigSpider.transform.position = new Vector3(2.606f, 0.845f, 3.83f);
                                    bigSpider.transform.rotation = new Quaternion(0f, 180f, 0f, 1);
                                    changeSpiderPosition = false;
                                }
                                smallSpider.SetActive(true);
                                mediumSpider.SetActive(true);
                                bigSpider.SetActive(true);
                                mediumSpiderIdle.SetActive(false);
                                break;
                            case 7:
                                Theca.SetActive(false);
                                smallSpider.SetActive(true);
                                mediumSpider.SetActive(true);
                                bigSpider.SetActive(true);
                                mediumSpiderIdle.SetActive(true);
                                break;
                        }
                        break;
                }

            }

            if (PanelSospendiInterazioneRagni.activeSelf)
            {
                smallSpider.SetActive(false);
                mediumSpider.SetActive(false);
                bigSpider.SetActive(false);
            }

        }//fine for

        if(stepSpiders == 8)
        {
            PanelInterazioneRagniTasti.SetActive(false);
            PanelCompletamentoPercorsoRagni.SetActive(true);
            smallSpider.SetActive(false);
            mediumSpider.SetActive(false);
            bigSpider.SetActive(false);
            mediumSpiderIdle.SetActive(false);
        }

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
        //PanelSospendiFotoRagni.SetActive(false);
        //PanelSospendiInterazioneRagni.SetActive(false);
        SceneManager.LoadScene("Home");
    }


    public void NextSpiderButton()
    {
        stepSpiders++;
    }


    public void PrevSpiderButton()
    {
        if(stepSpiders > 0)
        {
            stepSpiders--;
            if (stepSpiders < 4)
                putSpiderInTheca = true;
        }
        else
        {
            stepSpiders = 0;
        }
    }


    public void PauseInteractionSpidersButton()
    {
        for (int i = 0; i < arrayPanels.Count; i++)
        {
            if (((GameObject)arrayPanels[i]).activeSelf)
            {
                indexArrayPanel = i;
                ((GameObject)arrayPanels[i]).SetActive(false);
                PanelSospendiInterazioneRagni.SetActive(true);
                mediumSpiderIdle.SetActive(false);
                break;
            }
        }
    }


    public void ResumeInteractionSpidersButton()
    {
        PanelSospendiInterazioneRagni.SetActive(false);
        ((GameObject)arrayPanels[indexArrayPanel]).SetActive(true);
    }

    public void HomeButton()
    {
        SceneManager.LoadScene("Home");
    }


}
