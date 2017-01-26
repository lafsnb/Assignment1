using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	//gets the material of an object and
	//when it collides with another object
	//it changes to that things material

	void OnTriggerEnter(Collider _obj) {
		//if(_obj.tag == "Draggable") // check if obj has certain tag
		GetComponent<Renderer>().material = 
			_obj.GetComponent<Renderer>().material;
	}

	//Compare the ring material to the dot material
	//if = then change rings material to the dots Material
}
