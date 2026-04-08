using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolumeLevel : MonoBehaviour
{

    public Slider thisSlider;
    [Header("Slider Values During Runtime")]
    public float masterVolume;
    public float ambVolume;
    public float sfxVolume;
    public float uiVolume;


    public void SetVolume(string whatValue)
    {
        float sliderValue = thisSlider.value;

        if (whatValue == "Master")
        {
            Debug.Log("Changed Master level to:" +  thisSlider.value);
            masterVolume = thisSlider.value;
            AkSoundEngine.SetRTPCValue("vol_master", masterVolume); // tell wwise to set RTPC value to match the value of masterVolume's slider
        }

        if (whatValue == "Ambience")
        {
            Debug.Log("Changed Ambience level to:" + thisSlider.value);
            ambVolume = thisSlider.value;
            AkSoundEngine.SetRTPCValue("vol_ambience", ambVolume);
        }

        if (whatValue == "SFX")
        {
            Debug.Log("Changed SFX level to:" + thisSlider.value);
            sfxVolume = thisSlider.value;
            AkSoundEngine.SetRTPCValue("vol_sfx", sfxVolume);
        }

        if (whatValue == "UI")
        {
            Debug.Log("Changed UI level to:" + thisSlider.value);
            uiVolume = thisSlider.value;
            AkSoundEngine.SetRTPCValue("vol_UI", uiVolume);
        }


    }


}
