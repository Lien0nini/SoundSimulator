using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pageLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime=1f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadNextPage();
        }
    }

    public void LoadNextPage()
    {
        StartCoroutine(LoadPage(SceneManager.GetActiveScene().buildIndex+1));
       
    }

    IEnumerator LoadPage(int pageIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(pageIndex);
    }
}
