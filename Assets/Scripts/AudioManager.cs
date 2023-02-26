using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField] private AudioSource musicSource, effectSource;
    public Sounds[] musicSounds, sfxSounds;
    void Awake()
    {
        // Singleton //
        if(instance == null) // if there is no instance of the audio manager
        {
            instance = this; // then this becomes the instance
            DontDestroyOnLoad(gameObject); // don't destroy the audio manager when changing scenes
        }
        else
        {
            Destroy(gameObject); // if an instance already exists then destroy this instance
        }
        
    }
    private void Start()
    {

        PlayMusic("Background");
    }
    public void PlayMusic(string name)
    {
        Sounds s = Array.Find(musicSounds, x => x.name == name);

        if(s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }
    public void PlaySFX(string name)
    {
        Sounds s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            effectSource.PlayOneShot(s.clip);
        }
    }
    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
    }
    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }
    public void SFXVolume( float volume)
    {
        effectSource.volume = volume;
    }
}
