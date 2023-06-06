using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentClick : MonoBehaviour {

    [Range(0,1)]
    private int mouseButtonIndex = 0;

    private Transform target;
    
    private UnityEngine.AI.NavMeshAgent agent;

    void Start() {        
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();        
    }

    void Update() {

        if (Input.GetMouseButtonDown(mouseButtonIndex)) {
            RaycastHit hitData;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitData, 1000)) {
                agent.destination = hitData.point;
            }
        }
        
    }
}
