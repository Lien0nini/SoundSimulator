using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class cokeAudio : MonoBehaviour, IPointerDownHandler
{
    public AudioSource src;

    //play sound when the mouse hit the soda caps
    public void OnPointerDown(PointerEventData eventData) 
    {
        src.Play();
    }
}
