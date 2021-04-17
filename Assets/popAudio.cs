using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popAudio : MonoBehaviour
{
    public AudioSource src;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
     //button = GetComponent<Button> ();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMusic()
    {
        src.Play();
        
        //button.interactable = false;

    }
}
