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

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {

        increaseKarmaChoice.gameObject.SetActive(false);
        decreaseKarmaChoice.gameObject.SetActive(false);
        sentences = new Queue<string>();
        StartDialogue(scenario);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //Debug.Log("Starting convo with " + dialogue.name);



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
}
