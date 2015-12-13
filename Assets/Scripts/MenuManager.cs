using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class MenuManager : MonoBehaviour {


    public GameObject CenterPanel, OptionsPanel, CreditsPanel;

    public Slider volumeSlider;
    public Toggle checkMute;

    void OnAwake()
    {
        OnClickBack();
    }

    public void OnClickBack()
    {
        OptionsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        CenterPanel.SetActive(true);
    }

   public void OnClickContinue()
    {

    }

   public void OnClickNewGame()
   {
       GameController.Instance.LoadSpecificLevel(1);
   }

   public void OnClickOptions()
   {
       CenterPanel.SetActive(false);
       OptionsPanel.SetActive(true);

   }

    public void OnClickCredits()
    {
        CenterPanel.SetActive(false);
        CreditsPanel.SetActive(true);
    }

   public void OnClickQuit()
   {
       Application.Quit();
   }



   //------------------------------OPTION
   public void OnChangeSliderVolume()
   {
       PlayerPrefs.SetString("VolumeValue", volumeSlider.value.ToString());
       Debug.Log("Changed Volume value to " + volumeSlider.value.ToString());
   }

   public void OnChangeCheckMuteVolume()
   {
        Debug.Log("Mute : " + (checkMute.isOn? "Yup" : "Nope"));
        PlayerPrefs.SetString("VolumeValue", checkMute.isOn?"true":"false");
   }
}
