using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class cokeAudio : MonoBehaviour, IPointerDownHandler
{
    public AudioSource src;
    public Image ht;

    //play sound when the mouse hit the soda caps
    public void OnPointerDown(PointerEventData eventData) 
    {
        ht.color = Color.clear;
        src.Play();
    }
}
