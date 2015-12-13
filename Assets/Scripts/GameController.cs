using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GameController : MonoBehaviour {

    private int currentlevel = 1;

    public void Awake()
    {
        DOTween.Init(false, true, LogBehaviour.ErrorsOnly);
        DontDestroyOnLoad(this);
        instance = this;
    }

	void Start () {
        //GameObject.FindGameObjectWithTag("Musique").GetComponent<AudioSource>().Play();
        currentlevel = 1;
        print("Top à la vachette");
        LoadLevel("Level " + currentlevel);
	}
	
	void Update () {
	
	}

    public void Next()
    {
        currentlevel ++;
        LoadLevel("Level " + currentlevel);
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

}
