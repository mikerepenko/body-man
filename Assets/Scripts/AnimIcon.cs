using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimIcon : MonoBehaviour {

	private bool isRight = true;
	public float speed;
	public int countJump = 0;

	void Update () {
		if (gameObject.transform.localPosition.y >= 25)
			isRight = false;
		else if (gameObject.transform.localPosition.y <= 3) {
			isRight = true;
			countJump++;
			if (countJump > 10)
				countJump = 0;
		}
		if(isRight && countJump < 3)
			transform.localPosition = Vector3.MoveTowards (transform.localPosition, new Vector3 (transform.localPosition.x, 26f, transform.localPosition.z), speed * Time.deltaTime);
		else if(!isRight)
			transform.localPosition = Vector3.MoveTowards (transform.localPosition, new Vector3 (transform.localPosition.x, 2.8f, transform.localPosition.z), speed * Time.deltaTime);
	}
}
