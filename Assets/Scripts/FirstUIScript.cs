using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstUIScript : MonoBehaviour
{
   public void StartSomething() {

        SceneManager.LoadScene("BrockBowl");
    }


    public void QuitSomething()
    {
        Application.Quit();
        Debug.Log("Quit Something!!!!!");
    }

    public void startAltMap()
    {
        SceneManager.LoadScene("BowlingAlley");
    }

}
