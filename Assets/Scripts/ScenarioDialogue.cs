using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScenarioDialogue : MonoBehaviour
{
    //public TextMeshPro nameText;
    public TextMeshProUGUI dialogueText;
    public Dialogue scenario;

    public Button increaseKarmaChoice;
    public Button decreaseKarmaChoice;

    public string incKarmaActionName;
    public string decKarmaActionName;

    public int incKarmaAmt;
    public int decKarmaAmt;
    public int incHappinessAmt;
    public int decHappinessAmt;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        //calculate karma amount and put into var
        CalculateKarma();

        increaseKarmaChoice.onClick.AddListener(IncreaseKarmaButton);
        decreaseKarmaChoice.onClick.AddListener(DecreaseKarmaButton);

        increaseKarmaChoice.gameObject.SetActive(false);
        decreaseKarmaChoice.gameObject.SetActive(false);
        sentences = new Queue<string>();
        StartDialogue(scenario);
    }

    private void IncreaseKarmaButton()
    {
        PlayerSystem.instance.ChangeKarma(incKarmaAmt);
        PlayerSystem.instance.ChangeHappiness(incHappinessAmt);
        PlayerSystem.instance.actionsTaken.Enqueue(incKarmaActionName);
        Debug.Log("Karma: " + PlayerSystem.karmaLevel);
        Debug.Log("Happiness: " + PlayerSystem.happiness);
    }
    private void DecreaseKarmaButton()
    {
        PlayerSystem.instance.ChangeKarma(decKarmaAmt);
        PlayerSystem.instance.ChangeHappiness(decHappinessAmt);
        PlayerSystem.instance.actionsTaken.Enqueue(decKarmaActionName);
        Debug.Log("Karma: " + PlayerSystem.karmaLevel);
        Debug.Log("Happiness: " + PlayerSystem.happiness);

    }

    public void StartDialogue(Dialogue dialogue)
    {

        sentences.Clear();
        foreach (string s in dialogue.sentences)
        {
            sentences.Enqueue(s);
        }
    

        DisplayNextSentence();
    }



    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string s = sentences.Dequeue();
        dialogueText.text = s;
    }

    void EndDialogue()
    {
        //Show Button Options
        increaseKarmaChoice.gameObject.SetActive(true);
        decreaseKarmaChoice.gameObject.SetActive(true);

    }

    void CalculateKarma()
    {
        incKarmaAmt = incKarmaAmt + incKarmaAmt * (PlayerSystem.happiness) / 2;
        decKarmaAmt = decKarmaAmt + decKarmaAmt * (PlayerSystem.happiness) / 2;
    }
}
