using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource myMusic;
    public AudioClip Music1;
    public AudioClip Music2;
    public AudioClip Music3;
    int PlayingMusic = 3;


    // Start is called before the first frame update
    void Start()
    {
        PlayMusic();
    }

    void PlayMusic()
    {
        switch (PlayingMusic)
        {
            case 1:
                myMusic.clip = Music1;
                myMusic.Play();
                PlayingMusic = 2;
                break;

            case 2:
                myMusic.clip = Music2;
                myMusic.Play();
                PlayingMusic = 3;
                break;

            case 3:
                myMusic.clip = Music3;
                myMusic.Play();
                PlayingMusic = 1;
                break;



            default:
                break;
        }
        Invoke("PlayMusic", myMusic.clip.length);
    }

}
