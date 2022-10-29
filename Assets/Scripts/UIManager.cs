using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;
using UnityEngine;

public class UIManager : MonoBehaviour

{
    public GameObject SettingsPanel;

    public Image sound;
    public Image vibration;

    public Sprite soundOn;
    public Sprite soundOff;
    public Sprite vibrationOn;
    public Sprite vibrationOff;
	// Start is called before the first frame update

	public void OnClick_Settings()
	{
		if (SettingsPanel.activeSelf == false) //Turn settings on or off
		{

			SettingsPanel.SetActive(true); //Open settings panel
		}
		else
		{
			SettingsPanel.SetActive(false); //Close settings panel     
		}
	}
	public void OnClick_Sound() //Turn the sound on or off
	{
		if (PlayerPrefs.GetInt("SoundOn") == 1) //If sounds on
		{
			AudioListener.volume = 0; //Set total volume value = 0
			PlayerPrefs.SetInt("SoundOn", 0); //Set sounds off

			sound.sprite = soundOff; //Set sound button off
		}
		else
		{
			AudioListener.volume = 1; //Set total volume value = 1
			PlayerPrefs.SetInt("SoundOn", 1); //Set sounds on

			sound.sprite = soundOn; //Set sound button on
		}
	}
	public void OnClick_Vibration() //Turn vibration on or off
	{
		if (PlayerPrefs.GetInt("VibrationOn") == 1) //If vibration on
		{
			PlayerPrefs.SetInt("VibrationOn", 0); //Set vibration off
			vibration.sprite = vibrationOff; //Set vibration button off
		}
		else
		{
			Vibration.Vibrate(100); //Vibrate
			PlayerPrefs.SetInt("VibrationOn", 1); //Set vibration on
			vibration.sprite = vibrationOn; //Set vibration button on   
		}

	}

	public void OnClick_Play(string Game)
    {
		SceneManager.LoadScene(Game);
    }
}
