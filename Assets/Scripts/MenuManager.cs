using UnityEngine;
//using UnityEngine.UI;
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
<<<<<<< HEAD
       PlayerPrefs.SetString("VolumeValue", volumeSlider.value.ToString());
       Debug.Log("Changed Volume value to " + volumeSlider.value.ToString());
=======
     //  PlayerPrefs.SetString("VolumeValue", GameObject.Find("SliderVolume").GetComponent<Slider>().value.ToString());
>>>>>>> 4abeda6057b1337b3505fad44ed766bdce207ff2
   }

   public void OnChangeCheckMuteVolume()
   {
<<<<<<< HEAD
        Debug.Log("Mute : " + (checkMute.isOn? "Yup" : "Nope"));
        PlayerPrefs.SetString("VolumeValue", checkMute.isOn?"true":"false");
=======
       //if (GameObject.Find("SliderVolume").GetComponent<Toggle>().isOn == true)
       //    PlayerPrefs.SetString("VolumeValue", "0");
>>>>>>> 4abeda6057b1337b3505fad44ed766bdce207ff2
   }
}
