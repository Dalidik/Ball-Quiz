using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource soundSource;

    [Header("Audio Clip")]
    public AudioClip music;
    public AudioClip sound;


    private void Start()
    {


       musicSource.clip = music;
        musicSource.Play();

        soundSource.clip = sound;
        
    }



    public void MusicMuteHandler(bool mute)
    {
        if (mute)
        {

            musicSource.volume = 1;
        }
        else
        {

            musicSource.volume = 0;
        }
    }

    public void SoundMuteHandler(bool mute)
    {
        if (mute)
        {

            soundSource.volume = 1;
        }
        else
        {

            soundSource.volume = 0;
        }
    }

    public void ButtonClick()
    {
        soundSource.PlayOneShot(sound);
    }
}
