using UnityEngine;
using System.Collections;

public class HUDGame : MonoBehaviour {

    public GameObject MenuPause, OptionsPanel, CreditsPanel, Title, HUDLife;
    bool isGameMenuOpen = false;
    void OnAwake()
    {

        OptionsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        MenuPause.SetActive(false);
        Title.SetActive(false);
    }

    void start()
    {

        OptionsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        MenuPause.SetActive(false);
        Title.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGameMenuOpen)
            {
                ResumeGame();
                isGameMenuOpen = false;
            }
            else
            {
                OpenGameMenu();
                isGameMenuOpen = true;
            }
        }
    }

    public void OpenGameMenu()
    {
        Pause();
        Title.SetActive(true);
        MenuPause.SetActive(true);
    }

    public void CloseGameMenu()
    {
        Play();
        OnClickBack();
    }

    public void ResumeGame()
    {
        CloseGameMenu();
        Play();
    }

    public void Pause()
    {
        Time.timeScale = 0.0f;
    }

    public void Play()
    {
        Time.timeScale = 1.0f;
    }

    //----------------------------------Life manager

    public void loseLife
    {

    }


    //----------------------------------Pause
    public void OnClickContinue()
    {
        CloseGameMenu();
    }

    public void OnClickBack()
    {
        OptionsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        MenuPause.SetActive(false);
        Title.SetActive(false);
    }

    public void OnClickOptions()
    {
        MenuPause.SetActive(false);
        OptionsPanel.SetActive(true);

    }

    public void OnClickCredits()
    {
        MenuPause.SetActive(false);
        CreditsPanel.SetActive(true);
    }
}
