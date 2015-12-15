using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GameController : MonoBehaviour {

    public GameObject GameMenuCanvas;

    private int currentlevel;

    public void Awake()
    {
        DOTween.Init(false, true, LogBehaviour.ErrorsOnly);

		  if (instance == null) {
			  instance = this;
			  DontDestroyOnLoad( this );
		  } else {
			  Destroy( this );
		  }
    }



	void Start () {
		currentlevel = SceneManager.GetActiveScene().buildIndex;

		GameMenuCanvas = GameObject.FindObjectOfType<Canvas>().gameObject;
	}
    
  

    public void Next()
    {
        currentlevel ++;
		  LoadLevel( currentlevel );
    }


    public void LoadSpecificLevel(int level)
    {
        currentlevel = level;
        LoadLevel("Level " + level);
    }

    private void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

	 private void LoadLevel ( int level ) {
		 SceneManager.LoadScene( level );
	 }

    private static GameController instance = null;

    public static GameController Instance
    {
        get { return instance; }
    }

   


    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void showLife()
    {

    }

    public void hiddeLife()
    {

    }

	 public void RestartLevel () {
		 SceneManager.LoadScene( currentlevel );
	 }
}
