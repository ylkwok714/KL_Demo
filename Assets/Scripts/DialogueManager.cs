using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogueManager : MonoBehaviour

{
    public Animator transition;

    //public TextMeshPro nameText;
    public TextMeshProUGUI dialogueText;
    public RawImage emoticonImage;

    private Queue<string> sentences;
    private Queue<Texture> emoticons;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        emoticons = new Queue<Texture>();

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
        foreach(Texture e in dialogue.emoticons)
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
        Texture e = emoticons.Dequeue();
        dialogueText.text = s;
        emoticonImage.texture = e;
    }
    
    void EndDialogue()
    {
        Debug.Log("End of convo");
        if(SceneManager.GetActiveScene().name == "EndingTemplate")
        {
            StartCoroutine(TransitionScene("EndingStats"));
            //SceneManager.LoadScene("EndingStats");
            return;
        }
        StartCoroutine(TransitionScene("ActionSelection"));
        //SceneManager.LoadScene("ActionSelection");
    }

    IEnumerator TransitionScene(string name)
    {
        //Play animation
        transition.SetTrigger("Start");

        //wait for animation to finish
        yield return new WaitForSeconds(1f);

        //load scene
        SceneManager.LoadScene(name);

    }
}
