using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class popAudio : MonoBehaviour, IPointerDownHandler
{
    public AudioSource src;

    public void OnPointerDown(PointerEventData eventData) 
    {
        src.Play();
    }
}
