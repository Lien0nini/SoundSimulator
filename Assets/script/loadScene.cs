using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
     public void reloadGame()
    {
        SceneManager.LoadScene("bubble");
    }
}
