using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    public GameObject missionlog;
    public string mainGame;
    private bool isOn;


    public void LogToggle()
    {
        if (!isOn)
        {
            LogOpen();
            isOn = true;
            return;
        }
        else
        {
            LogClose();
            isOn = false;
            return;
        }
    }

    private void LogOpen()
    {
        missionlog.SetActive(true);
    }

    private void LogClose()
    {
        missionlog.SetActive(false);
    }

    public void ToGame()
    {
        SceneManager.LoadScene(mainGame);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
