using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	public Material mat;

	void OnTriggerEvent(Collider _obj) {
		
		Material objmat = _obj.GetComponent<Renderer>().material;
		if (objmat == mat)
		{
			print("Add points");
		} else {
			print("game over");
		}
	}

	//if ring is colored red
	//add points
	//else end game
}
