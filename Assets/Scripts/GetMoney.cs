using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMoney : MonoBehaviour {

	public float speed;

	void Update () {
		if (gameObject.transform.localPosition.y >= 300 ) {
			transform.position = new Vector3(transform.position.x,  2f, transform.position.z);
			gameObject.SetActive (false);
		}
		else
			transform.localPosition = Vector3.MoveTowards (transform.localPosition, new Vector3 (transform.position.x, 300f, transform.localPosition.z), speed * Time.deltaTime);
	}
}
