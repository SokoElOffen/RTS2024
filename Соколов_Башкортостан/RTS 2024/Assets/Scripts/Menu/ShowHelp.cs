using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShowHelp : MonoBehaviour, IPointerEnterHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (gameObject.name == "Play")
        {
            GameObject.Find("HelpText").GetComponent<TMP_Text>().text = "Играть";
        }
        if (gameObject.name == "Settings")
        {
            GameObject.Find("HelpText").GetComponent<TMP_Text>().text = "Настройки";
        }
        if (gameObject.name == "CloseButton")
        {
            GameObject.Find("HelpText").GetComponent<TMP_Text>().text = "Выйти из игры";
        }
    }
}
