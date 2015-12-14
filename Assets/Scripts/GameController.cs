using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GameController : MonoBehaviour {

    public GameObject GameMenuCanvas;
    

    private int currentlevel = 1;

    public void Awake()
    {
        DOTween.Init(false, true, LogBehaviour.ErrorsOnly);
        DontDestroyOnLoad(this);
        instance = this;
    }



	void Start () {
        currentlevel = 1;
        print("Top à la vachette");
        LoadLevel("MainMenu");
	}
    
  

    public void Next()
    {
        currentlevel ++;
        LoadLevel("Level " + currentlevel);
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

    private static GameController instance = null;

    public static GameController Instance
    {
        get { return instance; }
    }

   


    public void GoToMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void showLife()
    {

    }

    public void hiddeLife()
    {

    }
}
