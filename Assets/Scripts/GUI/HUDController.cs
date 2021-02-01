using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HUDController : MonoBehaviour
{
    public TMP_Text textTimeScale;
    public TMP_Text SensScale;
    public TMP_Text zoomScale;
    public GameObject camRig;
    private LookAt comp;

    private bool isVisible = false;
    public GameObject slider1;
    public GameObject slider2;
    public GameObject quitButton;
    public GameObject toggleOrbits;
    public GameObject panel;
    public AudioSource boop;

    // Start is called before the first frame update
    void Start()
    {
        comp = camRig.GetComponent<LookAt>();
    }
    void playBoop()
    {
        boop.pitch = Random.Range(.25f, 1.25f);
        boop.Play();
    }
    public void pauseMenu()
    {
        playBoop();
        if (isVisible)
        {
            quitButton.SetActive(false);
            slider1.SetActive(false);
            slider2.SetActive(false);
            panel.SetActive(false);
            toggleOrbits.SetActive(false);
            isVisible = false;
        }
        else
        {
            quitButton.SetActive(true);
            slider1.SetActive(true);
            slider2.SetActive(true);
            panel.SetActive(true);
            toggleOrbits.SetActive(true);
            isVisible = true;
        }
    }
    public void backToMenu()
    {
        playBoop();
        Invoke("loadMainMenu", 1);
    }
    public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void SliderUpdated(float amt)
    {
        if (amt < 0)
        {
            GameManager.timeSpeed = -amt;
            GameManager.rewind = true;
            textTimeScale.text = System.Math.Round(GameManager.timeSpeed, 1).ToString();

        }
        else
        {
            GameManager.timeSpeed = amt;
            GameManager.rewind = false;
            textTimeScale.text = System.Math.Round(GameManager.timeSpeed, 1).ToString();
        }

    }
    public void SenSliderUpdated(float amt)
    {
        comp.mouseSensitivityY = amt;
        comp.mouseSensitivityX = amt;
        SensScale.text = System.Math.Round(comp.mouseSensitivityY, 0).ToString();
    }
    public void ZoomSliderUpdated(float amt)
    {
        comp.mouseScrollMult = amt;
        zoomScale.text = System.Math.Round(comp.mouseScrollMult, 0).ToString();
    }
    public void showOrbits(bool isVis)
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("orbits");

        for (int i = 0; i < objs.Length; i++)
        {
            objs[i].GetComponent<LineRenderer>().enabled = isVis;
        }
    }
    public void focusSun()
    {
        playBoop();
        comp.lookAtValue = 0;
        comp.doOnce = true;
    }
    public void focusPlanetOne()
    {
        playBoop();
        comp.lookAtValue = 1;
        comp.doOnce = true;
    }
    public void focusPlanetTwo()
    {
        playBoop();
        comp.lookAtValue = 2;
        comp.doOnce = true;
    }
    public void focusPlanetThree()
    {
        playBoop();
        comp.lookAtValue = 3;
        comp.doOnce = true;
    }
    public void focusPlanetFour()
    {
        playBoop();
        comp.lookAtValue = 4;
        comp.doOnce = true;
    }
    public void focusPlanetFive()
    {
        playBoop();
        comp.lookAtValue = 5;
        comp.doOnce = true;
    }
}
