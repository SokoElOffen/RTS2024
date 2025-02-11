using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOnWorld : MonoBehaviour
{
    [SerializeField] private Ray ray;
    [SerializeField] private RaycastHit hit;
    private GameObject finish;
    // Start is called before the first frame update
    void Start()
    {
        finish = GameObject.Find("finish");
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit) && hit.transform.name == "Grass")
        {
            finish.transform.position = hit.point;


        }
    }
}
