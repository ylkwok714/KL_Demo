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
        if(endingKarmaLevel >= 0 && endingHappiness >= 0)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(highKarmaHighHappinessDialogue);

        }
        if (endingKarmaLevel >= 0 && endingHappiness < 0)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(highKarmaLowHappinessDialogue);

        }
        if (endingKarmaLevel < 0 && endingHappiness >= 0)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(lowKarmaHighHappinessDialogue);

        }
        if (endingKarmaLevel < 0 && endingHappiness < 0)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(lowKarmaLowHappinessDialogue);

        }

    }
}
