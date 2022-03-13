using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingDialogue : MonoBehaviour
{
    int endingKarmaLevel;
    int endingHappiness;

    public Dialogue highKarmaHighHappinessDialogue;
    public Dialogue highKarmaLowHappinessDialogue;
    public Dialogue lowKarmaHighHappinessDialogue;
    public Dialogue lowKarmaLowHappinessDialogue;


    // Start is called before the first frame update
    void Start()
    {
        endingKarmaLevel = PlayerSystem.karmaLevel;
        endingHappiness = PlayerSystem.happiness;
        TriggerEndingDialogue();
    }

    public void TriggerEndingDialogue()
    {
        //high karma, high happiness - 
        if(endingKarmaLevel >= 0 && endingHappiness >= 0)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(highKarmaHighHappinessDialogue);
            FindObjectOfType<AudioManager>().PlaySound("End_hKhH");

        }
        if (endingKarmaLevel >= 0 && endingHappiness < 0)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(highKarmaLowHappinessDialogue);
            FindObjectOfType<AudioManager>().PlaySound("End_hKlH");

        }
        if (endingKarmaLevel < 0 && endingHappiness >= 0)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(lowKarmaHighHappinessDialogue);
            FindObjectOfType<AudioManager>().PlaySound("End_lKhH");

        }
        if (endingKarmaLevel < 0 && endingHappiness < 0)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(lowKarmaLowHappinessDialogue);
            FindObjectOfType<AudioManager>().PlaySound("End_lKlH");

        }

    }
}
