using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    void Awake()
    {
        //if (instance == null)
        //{
        //    instance = this;
        //}
        //else
        //{
        //    Destroy(gameObject);
        //    return;
        //}

        //DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        PlayBGM();
    }

    public void PlaySound(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound " + name + " not found");
            return;
        }
        s.source.Play();
    }
    public void StopSound(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound " + name + " not found");
            return;
        }

        //s.source.volume = 0;
        //s.source.pitch = 0;

        s.source.Stop();
    }

    void PlayBGM()
    {
        //opening title music
        if(SceneManager.GetActiveScene().name == "TitleScene")
        {
            FindObjectOfType<AudioManager>().PlaySound("OpeningTitle");
        }

        //disembodied voice thematic music
        else if (SceneManager.GetActiveScene().name == "TemplateScene" || SceneManager.GetActiveScene().name == "MidwayReveal")
        {
            //FindObjectOfType<AudioManager>().StopSound("OpeningTitle");
            FindObjectOfType<AudioManager>().PlaySound("DVTheme");
        }

        //action selection scene music
        else if(SceneManager.GetActiveScene().name == "ActionSelection")
        {
            FindObjectOfType<AudioManager>().PlaySound("ActionGong");

        }

        //good karma randomized audio effect
         if (SceneManager.GetActiveScene().name == "DecreaseKarmaTemplate")
        {
            int num = (int)Random.Range(1.0f,5.0f);
            string soundName = "GoodKarma" + num;
            FindObjectOfType<AudioManager>().PlaySound(soundName);

        }

        //bad karma randomized audio effect
        else if (SceneManager.GetActiveScene().name == "IncreaseKarmaTemplate")
        {
            int num = (int)Random.Range(1.0f, 5.0f);
            string soundName = "BadKarma" + num;
            FindObjectOfType<AudioManager>().PlaySound(soundName);

        }

        /*
         * The 4 scenarios
         */
        //soup kitchen background sfx
         if(SceneManager.GetActiveScene().name == "Volunteer_SoupKitchen")
        {
            FindObjectOfType<AudioManager>().PlaySound("SoupKitchen");
        }

        //lecture background sfx
        else if (SceneManager.GetActiveScene().name == "AdvancedClasses_LectureClass")
        {
            FindObjectOfType<AudioManager>().PlaySound("LectureClass");
        }

        //mentorship background sfx
        else if (SceneManager.GetActiveScene().name == "Internship_Mentorship")
        {
            FindObjectOfType<AudioManager>().PlaySound("Mentorship");
        }

        //meet partner background sfx
        else if (SceneManager.GetActiveScene().name == "SideProjects_MeetPartner")
        {
            FindObjectOfType<AudioManager>().PlaySound("MeetPartner");
        }

        //(4) ending music - 
    }
}
