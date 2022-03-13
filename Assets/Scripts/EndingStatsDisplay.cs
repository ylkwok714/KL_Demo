using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndingStatsDisplay : MonoBehaviour
{
    //ask for array text boxes to list 
    public TextMeshProUGUI[] statBoxes;

    // Start is called before the first frame update
    void Start()
    {
        DisplayEndingStats();
    }

    void DisplayEndingStats()
    {
        //int count = PlayerSystem.instance.actionsTaken.Count;
        for (int i = 0; i < statBoxes.Length; i++)
        {
            //int daynumber = i + 1;
            statBoxes[i].text = PlayerSystem.instance.actionsTaken.Dequeue();
            //Debug.Log(PlayerSystem.instance.actionsTaken.Dequeue());
            //statBoxes[i].col
        }

    }




}
