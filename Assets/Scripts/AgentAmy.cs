using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentAmy : MonoBehaviour
{

    public Transform target;
    NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.position;

        if (agent.remainingDistance > 1f) {
            // TODO estado animación a camiñando
        } else {
            // TODO estado animación a espera
        }
    }
}
