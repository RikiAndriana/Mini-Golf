using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenuManager : MonoBehaviour
{
    // TODO Slider
    public Slider volumeSlider;

    private void Awake()
    {
        // TODO Mute
        if (AudioManager.Instance.music.mute == true)
        {
            toggle.isOn = false;
            Debug.Log("Status Music Mute:" + AudioManager.Instance.music.mute);
        }
        else
        {
            toggle.isOn = true;
            Debug.Log("Status Music Mute :" + AudioManager.Instance.music.mute);
        }
    }

    private void Start()
    {
        // TODO Load Volume
        volumeSlider.value = AudioManager.Instance.music.volume;
        AudioManager.Instance.LoadVolume();
        Debug.Log("Volume Music : " + volumeSlider.value);
    }

    // TODO slider volume
    public void SliderVolume()
    {
        AudioManager.Instance.music.volume = volumeSlider.value;
        Debug.Log("Volume Music : " + volumeSlider.value);
    }

    // TODO mute
    public Toggle toggle;
    public void SetMute()
    {
        if (toggle.isOn == true)
        {
            AudioManager.Instance.music.mute = true;
            Debug.Log("Status Music Mute :" + AudioManager.Instance.music.mute);
        }
        else
        {
            AudioManager.Instance.music.mute = false;
            Debug.Log("Status Music Mute :" + AudioManager.Instance.music.mute);
        }
    }

    // TODO keluar game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Keluar Aplikasi");
    }
}
