using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerSystem : MonoBehaviour
{
    public static int karmaLevel ;
    public static int happiness;
    public static int day = 0;

    public TextMeshProUGUI dayCounterText;

    private void Start()
    {
        DisplayDayCounter();
    }

    public void DisplayDayCounter()
    {
        dayCounterText.text = "DAY " + day;
    }

    public void NextDay()
    {
        day++;
    }
}
