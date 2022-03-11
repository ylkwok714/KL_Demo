using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ButtonSounds : MonoBehaviour
{
    public AudioSource buttonObj;
    public AudioClip hoverAudio;
    public AudioClip clickAudio;

    public void HoverSound()
    {
        buttonObj.PlayOneShot(hoverAudio);
    }
    public void SelectSound()
    {
        buttonObj.PlayOneShot(clickAudio);
    }

}
