using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {
    public GameObject playerHud;

    void Start()
    {
        GameController.Instance.GameMenuCanvas = playerHud;
    }

    public void OnClickResume()
    {
        GameController.Instance.ResumeGame();
    }

    public void OnClickMainMenu()
    {
        GameController.Instance.GoToMainMenu();
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
