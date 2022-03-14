using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public Animator transition;
    public string sceneName;
    public float transitionTime = 1f;
    //public Button continueButton;
    //bool haveDoneMidwayReveal = false;
    public void NextScene()
    {
        if (sceneName == "ActionSelection")
        {
            PlayerSystem.day++;
            if(PlayerSystem.day == 3)
            {
                StartCoroutine(SpecialSceneTransition("MidwayReveal"));
                //SceneManager.LoadScene("MidwayReveal");
                return;
            }
            if(PlayerSystem.day == 5)
            {
                StartCoroutine(SpecialSceneTransition("EndingTemplate"));
                //SceneManager.LoadScene("EndingTemplate");
                return;
            }
        }

        StartCoroutine(DelaySceneTransition());

    }

    public IEnumerator DelaySceneTransition()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        //yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneName);

    }

    public IEnumerator SpecialSceneTransition(string name)
    {
        //Play animation
        transition.SetTrigger("Start");

        //wait for animation to finish
        yield return new WaitForSeconds(transitionTime);

        //load scene
        SceneManager.LoadScene(name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LogChosenButton(string action)
    {
        PlayerSystem.instance.buttonsToTurnOff.Add(action);
    }
}
