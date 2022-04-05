using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainAnim : MonoBehaviour {

	private bool isMS;
	public float speed;

	public void Main(){
		isMS = false;
	}
	public void Shop(){
		isMS = true;
	}
	void Update(){
		if(isMS)
			transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-20f, transform.position.y, transform.position.z), speed * 0.02f);
		else
			transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0f, transform.position.y, transform.position.z), speed * 0.02f);
	}
}
