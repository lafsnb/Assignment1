using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity {

	// let the player attack
	// I want to eventually move with wasd, but this works for now.
	UnityEngine.AI.NavMeshAgent agent;
        
        void Start() {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }
        
        void Update() {
            if (Input.GetMouseButtonDown(0)) {
                RaycastHit hit;
                
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
                    agent.destination = hit.point;
                }
            }
        }
}
