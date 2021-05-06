using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class hint : MonoBehaviour, IPointerDownHandler
{
    public Image ht;

    // show the text when the user clicks the page
    public void OnPointerDown(PointerEventData eventData) 
    {
        ht.color = Color.clear;
    }
}
