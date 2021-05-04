using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
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
