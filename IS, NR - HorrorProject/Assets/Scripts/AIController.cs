using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform PlayerTransform;

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(PlayerTransform.position);
    }
}
