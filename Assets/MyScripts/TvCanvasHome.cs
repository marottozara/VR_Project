using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TvCanvasHome : MonoBehaviour
{

    public GameObject PanelHome;

    public GameObject PanelAcrofobia01;
    public GameObject PanelAcrofobia02;

    public ArrayList arrayAcrofobiaPanels = new ArrayList();

    // Use this for initialization
    void Start()
    {

        arrayAcrofobiaPanels.Add(PanelAcrofobia01);
        arrayAcrofobiaPanels.Add(PanelAcrofobia02);

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void AracnofobiaButton()
    {
        SceneManager.LoadScene("Studio");
    }


    public void AcrofobiaButton()
    {
        PanelHome.SetActive(false);
        PanelAcrofobia01.SetActive(true);
    }

    public void PowerOffButton()
    {
        Debug.Log("Chiudo l'applicazione...");
        Application.Quit();
    }


    public void AcrofobiaNextButton()
    {
        for (int i = 0; i < arrayAcrofobiaPanels.Count; i++)
        {
            if (((GameObject)arrayAcrofobiaPanels[i]).activeSelf)
            {
                ((GameObject)arrayAcrofobiaPanels[i]).SetActive(false);
                ((GameObject)arrayAcrofobiaPanels[i + 1]).SetActive(true);
                break;
            }
        }
    }


    public void AcrofobiaBackButton()
    {
        for (int i = 0; i < arrayAcrofobiaPanels.Count; i++)
        {
            if (((GameObject)arrayAcrofobiaPanels[i]).activeSelf)
            {
                ((GameObject)arrayAcrofobiaPanels[i]).SetActive(false);
                if (i == 0)
                {
                    PanelHome.SetActive(true);
                }
                else
                {
                    ((GameObject)arrayAcrofobiaPanels[i - 1]).SetActive(true);
                }
                break;
            }
        }
    }


    public void AcrofobiaStartButton()
    {
        SceneManager.LoadScene("Mountain");
    }
}