using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class popAudio : MonoBehaviour, IPointerDownHandler
{
    public AudioSource src;

    // play sound when the bubble was hitted 
    public void OnPointerDown(PointerEventData eventData)
    {
        src.Play();
    }
}
