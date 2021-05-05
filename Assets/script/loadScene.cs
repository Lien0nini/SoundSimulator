using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
// use the LoadScene methos to load the needed scenes, 
//so that the user would be direct to that scene when click the correspond button
     
     public void loadBubble()
    {
        SceneManager.LoadScene("bubble");
    }

    public void loadCoke()
    {
        SceneManager.LoadScene("coke");
    }

    public void loadNoodle()
    {
        SceneManager.LoadScene("noodle");
    }

    public void baketoMenu()
    {
        SceneManager.LoadScene("menue");
    }
}
