using UnityEngine;
using UnityEngine.UI;
//using System.Collections;



public class MenuManager : MonoBehaviour {


    public GameObject CenterPanel;
    public GameObject OptionsPanel;
    void OnAwake()
    {
        OnClickBack();
    }

    public void OnClickBack()
    {
        OptionsPanel.SetActive(false);
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

   public void OnClickQuit()
   {
       Application.Quit();
   }



   //------------------------------OPTION
   public void OnChangeSliderVolume()
   {
       PlayerPrefs.SetString("VolumeValue", GameObject.Find("SliderVolume").GetComponent<Slider>().value.ToString());
   }

   public void OnChangeCheckMuteVolume()
   {
       if (GameObject.Find("SliderVolume").GetComponent<Toggle>().isOn == true)
           PlayerPrefs.SetString("VolumeValue", "0");
   }
}
