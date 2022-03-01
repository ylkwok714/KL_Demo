using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeManager : MonoBehaviour
{

    public RawImage karmaPlaceholder;
    public RawImage happinessPlaceholder;

    // Start is called before the first frame update
    void Awake()
    {
        DisplayGauges();
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
}
