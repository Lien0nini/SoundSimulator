using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class surprise : MonoBehaviour, IPointerDownHandler
{
    public Text sup;

    // show the text when the user clicks the page
    public void OnPointerDown(PointerEventData eventData) 
    {
        sup.color = Color.gray;
        Debug.Log("work");
    }
}
