using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cokeAudio : MonoBehaviour
{
    public AudioSource src;
    //int n = 0;

    // public Button button;
    // Start is called before the first frame update
    void Start()
    {
        //if (n >= 1){
        //   button.interactable = false;
        //}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMusic()
    {
        src.Play();
        //n = n+1;
       
        

    }
}
