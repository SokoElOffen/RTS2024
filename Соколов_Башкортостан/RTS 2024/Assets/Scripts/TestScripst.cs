using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI.Navigation;
using UnityEngine.Experimental.AI;
using UnityEngine.Animations;
using UnityEngine.AI;
using UnityEditor.AI;

public class TestScripst : MonoBehaviour
{
    private NavMeshAgent Agent;
    private NavMeshSurface Grass;
    [SerializeField] private GameObject object1;
    [SerializeField] private bool triger1;
    [SerializeField] private bool triger2;
    [SerializeField] private Vector3 Delta;

    public void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        Grass = GameObject.Find("Grass").GetComponent<NavMeshSurface>();
    }

    public void Update()
    {
       if (triger1)
       {
           MoveTo();
       }
       if (Input.GetKeyDown("1") && triger2)
       {
           Grass.BuildNavMesh();
       }
    }

    private void MoveTo()
    {
        Agent.destination = object1.transform.position;
    }
}
