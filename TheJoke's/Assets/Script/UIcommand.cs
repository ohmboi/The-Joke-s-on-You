using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIcommand : MonoBehaviour
{
    public GameObject Gamemodesetting, Gamemenusetting, GameCradit;
    public void StartGame()
    {
        Gamemodesetting.SetActive(true);
        Gamemenusetting.SetActive(false);
    }
    public void GamemodeDay()
    {
        SceneManager.LoadScene("DayEasyMode");
    }
    public void GamemodeNight()
    {
        SceneManager.LoadScene("NightHardMode");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Craditdetail()
    {
        Gamemenusetting.SetActive(false);
        GameCradit.SetActive(true);
    }
    public void backmenu()
    {
        GameCradit.SetActive(false);
        Gamemenusetting.SetActive(true);
    }
}
