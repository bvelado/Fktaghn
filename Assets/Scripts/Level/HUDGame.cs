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
	 public GameObject FlashPanel;
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
		 if (MenuPanel == null) {
			 MenuPanel = GameObject.Find( "GameMenuPanel" );
		 }
		 if (lives == null || lives.Length == 0) {
			 RectTransform LivesPanel = GameObject.Find( "LifePanel" ).GetComponent<RectTransform>();
			 lives = new GameObject[3];
			 for (int i = 0; i > 2 ;i++) {
				 lives[i] = LivesPanel.FindChild( "Life"+i ).gameObject;
				 Debug.Log( lives[i].name );
			 }
		 }

		 GetComponent<Canvas>().worldCamera = Camera.main;
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
		 MenuPanel.SetActive( false );
    }

    public void ResumeGame()
    {
		 Play(); 
		 CloseGameMenu();
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
		 StartCoroutine( FeedbackTookDamage() );
    }

	 IEnumerator FeedbackTookDamage () {
		 FlashPanel.SetActive( true );
		 yield return new WaitForSeconds( 3.0f );
		 FlashPanel.SetActive( false );
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
