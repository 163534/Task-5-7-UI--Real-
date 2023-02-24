using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsScript : MonoBehaviour
{
    // I wanted to experiment more with arrays; I had a lot of fun with arrays on this one //
    public GameObject[] menus; // 0 = main menu, 1 = Options menu, 2 = Instructions menu, 3 = Difficulty menu 
    public bool[] switcher; // Used to detect current menu for the back button
    
    public void StartButton()
    {
        menus[0].SetActive(false);
        menus[3].SetActive(true);
        if (menus[3].activeInHierarchy)
        {
            switcher[2] = true;
        }
        else
        {
            switcher[2] = false;
        }
    }
    public void OptionsButton()
    {
        menus[0].SetActive(false);
        menus[1].SetActive(true);
        if (menus[1].activeInHierarchy)
        {
            switcher[0] = true;
        }
        else
        {
            switcher[0] = false;
        }
    }
    public void InstructionsButton()
    {
        menus[0].SetActive(false);
        menus[2].SetActive(true);
        if (menus[2].activeInHierarchy)
        {
            switcher[1] = true;
        }
        else
        {
            switcher[1] = false;
        }
    }
    public void EasyButton()
    {

    }
    public void BackButton()
    {
        if (switcher[0])
        {
            menus[1].SetActive(false);
            menus[0].SetActive(true);
        }
        if (switcher[1])
        {
            menus[2].SetActive(false);
            menus[0].SetActive(true);
        }
        if (switcher[2])
        {
            menus[3].SetActive(false);
            menus[0].SetActive(true);
        }
        
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
