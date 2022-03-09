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
         
        SceneManager.LoadScene(sceneName);

    }
}
