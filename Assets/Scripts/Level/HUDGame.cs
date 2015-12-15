using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class HUDGame : MonoBehaviour {

	private static HUDGame instance;
	public static HUDGame Instance {
		get {
			return instance;
		}
	}

    public GameObject MenuPanel;
	 public GameObject[] lives;

	 public Sprite lostLifeSprite;

    bool isGameMenuOpen = false;

	 int livesLost = 0;

    void Awake()
    {
		 if (instance == null) {
			 instance = this;
		 } else {
			 Destroy( this );
		 }
    }

	 void Start () {
	 
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
        MenuPanel.SetActive(true);
    }

    public void CloseGameMenu()
    {
		 ResumeGame();
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

    public void loseLife()
    {
		 lives[livesLost].GetComponent<Image>().overrideSprite = lostLifeSprite;
		 livesLost++;
    }


    //----------------------------------Pause
    public void OnClickResume()
    {
		 ResumeGame();
    }

	 public void OnClickMainMenu () {
		 GameController.Instance.GoToMainMenu();
	 }

    public void OnClickExit()
    {
		 Application.Quit();
    }
}
