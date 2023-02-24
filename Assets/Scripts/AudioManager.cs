using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    void Awake()
    {
        if(instance == null) // if there is no instance of the audio manager
        {
            instance = this; // then this becomes the instance
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); // if an instance already exists then destroy this instance
        }
        
    }
}
