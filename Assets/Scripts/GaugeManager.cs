using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeManager : MonoBehaviour
{
    public Image[] karmaGauges;
    public Image[] happinessGauges;

    public Image karmaPlaceholder;
    public Image happinessPlaceholder;

    // Start is called before the first frame update
    void Start()
    {
        DisplayGauges();
    }

    public void DisplayGauges()
    {
        //if karma is at certain level, then show certain gauge


        //if happiness is at certain slider, then show gauge
    }
}
