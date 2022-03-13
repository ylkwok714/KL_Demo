using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public string sceneName;
    //public Button continueButton;
    //bool haveDoneMidwayReveal = false;
    public void NextScene()
    {
        if (sceneName == "ActionSelection")
        {
            PlayerSystem.day++;
            if(PlayerSystem.day == 3)
            {
                SceneManager.LoadScene("MidwayReveal");
                return;
            }
            if(PlayerSystem.day == 5)
            {
                SceneManager.LoadScene("EndingTemplate");
                return;
            }
        }

        StartCoroutine(DelaySceneTransition());

    }

    public IEnumerator DelaySceneTransition()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneName);

    }

    public void LogChosenButton(string action)
    {
        PlayerSystem.instance.buttonsToTurnOff.Add(action);
    }
}
