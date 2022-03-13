using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeManager : MonoBehaviour
{

    public RawImage karmaPlaceholder;
    public RawImage happinessPlaceholder;

    public Button volunteerButton;
    public Button sideprojButton;
    public Button internButton;
    public Button advclassButton;

    // Start is called before the first frame update
    void Awake()
    {
        DisplayGauges();
        ToggleButtons();
    }

    public void DisplayGauges()
    {
        //if karma is at certain level, then show certain gauge
        //karmaPlaceholder.texture = PlayerSystem.karmaImage.texture;

        //if happiness is at certain slider, then show gauge
        if(PlayerSystem.day > 2)
        {
            happinessPlaceholder.gameObject.SetActive(true);
            //happinessPlaceholder.texture = PlayerSystem.happinessImage.texture;

        }
        else
        {
            happinessPlaceholder.gameObject.SetActive(false);
        }
    }

    public void ToggleButtons()
    {
        List<string> buttons = PlayerSystem.instance.buttonsToTurnOff;
        for(int i = 0; i < buttons.Count; i++)
        {
            if(buttons[i] == "Volunteer")
            {
                volunteerButton.gameObject.SetActive(false);
            }
            if (buttons[i] == "SideProjects")
            {
                sideprojButton.gameObject.SetActive(false);
            }
            if (buttons[i] == "Internship")
            {
                internButton.gameObject.SetActive(false);
            }
            if (buttons[i] == "AdvancedClasses")
            {
                advclassButton.gameObject.SetActive(false);
            }

        }
    }
}
