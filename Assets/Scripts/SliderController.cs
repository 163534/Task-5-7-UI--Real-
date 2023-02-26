using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider musicSlider, sfxSlider;

    public void ToggleMusic()
    {
        AudioManager.instance.ToggleMusic(); // not the same as the method above: comes from AudioManager
    }
    public void MusicVolumee()
    {
        AudioManager.instance.MusicVolume(musicSlider.value);
    }
    public void SFXVolumee()
    {
        AudioManager.instance.SFXVolume(sfxSlider.value);
    }
}
