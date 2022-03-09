using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerSystem : MonoBehaviour
{
    public static PlayerSystem instance;

    public static int karmaLevel = 0;
    public static int happiness = 0;
    public static int day = 1;
    public  RawImage karmaImage;
    public  RawImage happinessImage;

    public Texture goodKarma;
    public Texture midKarma;
    public Texture badKarma;

    public Texture highHappiness;
    public Texture midHappiness;
    public Texture lowHappiness;

    public Queue<string> actionsTaken = new Queue<string>();
    public string actionEffect;

    public TextMeshProUGUI dayCounterText;

    private void Awake()
    {
        //instance = this;
        DisplayDayCounter();
        SetKarmaImage();
        SetHappinessImage();

        DontDestroyOnLoad(this);
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }


    }


    private void Start()
    {
        //DisplayDayCounter();
        //SetKarmaImage();
        //SetHappinessImage();
    }

    private void Update()
    {
        
    }

    public void DisplayDayCounter()
    {
        dayCounterText.text = "DAY " + day;
    }

    public void NextDay()
    {
        day++;
    }

    public void SetKarmaImage()
    {
        if (karmaLevel > 0) karmaImage.texture = badKarma;
        if (karmaLevel < 0) karmaImage.texture = goodKarma;
    }
    public void SetHappinessImage()
    {
        if (happiness > 0) happinessImage.texture = highHappiness;
        if (happiness < 0) happinessImage.texture = lowHappiness;

    }

    public void ChangeKarma(int change)
    {
        karmaLevel += change;
    }
    public void ChangeHappiness(int change)
    {
        happiness += change;
    }

    public int GetKarmaLevel()
    {
        return karmaLevel;
    }

    public int GetHappiness()
    {
        return happiness;
    }
}
