using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : Entity {

	// Let the enemy attack when within a range
	// The enemy will not follow you until within a range.

	public Transform target;
	NavMeshAgent agent;

	void Start() {
		agent = GetComponent<NavMeshAgent>();
	}

	void Update() {
		agent.SetDestination(target.position);
	}
}
