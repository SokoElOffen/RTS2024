using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScripst : MonoBehaviour
{
    [SerializeField] private GameObject object1;
    [SerializeField] private Vector2 Delta;

    public void Update()
    {
        object1.GetComponent<RectTransform>().sizeDelta = Delta;
    }
}
