using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SimpleDialogue : MonoBehaviour
{
    public TextMeshProUGUI effectDialoguePlaceholder;   

    // Start is called before the first frame update
    void Start()
    {
        GetEffectDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetEffectDialogue()
    {
        effectDialoguePlaceholder.text = PlayerSystem.instance.actionEffect;
    }
}
