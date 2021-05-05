using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{   
    // quit the game 
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
