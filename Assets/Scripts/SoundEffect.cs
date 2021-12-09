using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioSource SoundPop;

    public void playSoundEffect()
    {
        SoundPop.Play();
    }
}