using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonsSize : MonoBehaviour
{
    [SerializeField] private GameObject[] menuButtons = new GameObject[0];
    void SetSize(float width, float height)
    {
        foreach (var button in menuButtons) 
        { 
            button.GetComponent<RectTransform>().sizeDelta = new Vector2(width, height);
        }
    }
}
