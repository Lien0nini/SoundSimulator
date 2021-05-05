using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class noddleAudio : MonoBehaviour, IPointerDownHandler
{
    public AudioSource src;
    int a = 0;

    public void OnPointerDown(PointerEventData eventData) 
    {
        if (a < 1)
        {
            src.Play();
            a=a+1;
        }
    }
}
