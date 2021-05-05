using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class cokeAudio : MonoBehaviour, IPointerDownHandler
{
    public AudioSource src;

    public void OnPointerDown(PointerEventData eventData) 
    //play sound when the mouse hit the soda caps
    {
        src.Play();
    }
}
