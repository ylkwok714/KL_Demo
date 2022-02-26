using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public string sceneName;
    //public Button continueButton;
    public void NextScene()
    {
        if (sceneName == "ActionSelection")
        {
            PlayerSystem.day++;
        }
        SceneManager.LoadScene(sceneName);
        
    }
}
