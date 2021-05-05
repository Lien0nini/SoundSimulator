using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pageLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime=1f;

    // jump to the next scene when user click the mouse
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadNextPage();
        }
    }

    //Load the next scene every 1 sec (transitionTime)
    public void LoadNextPage()
    {
        StartCoroutine(LoadPage(SceneManager.GetActiveScene().buildIndex+1));
    }

    // load the input scene after the start condition has triggered
    IEnumerator LoadPage(int pageIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(pageIndex);
    }
}
