using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogueManager : MonoBehaviour

{
    //public TextMeshPro nameText;
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI emoticonText;

    private Queue<string> sentences;
    private Queue<string> emoticons;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        emoticons = new Queue<string>();

    }

    public void StartDialogue(Dialogue dialogue)
    {
        //Debug.Log("Starting convo with " + dialogue.name);



        sentences.Clear();
        emoticons.Clear();
        foreach(string s in dialogue.sentences)
        {
            sentences.Enqueue(s);
        }
        foreach(string e in dialogue.emoticons)
        {
            emoticons.Enqueue(e);
        }

        DisplayNextSentence();
    }


    
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string s = sentences.Dequeue();
        string e = emoticons.Dequeue();
        dialogueText.text = s;
        emoticonText.text = e;
    }
    
    void EndDialogue()
    {
        Debug.Log("End of convo");
        SceneManager.LoadScene("ActionSelection");
    }
}
