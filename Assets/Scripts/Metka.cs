using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metka : MonoBehaviour {

	public float speed;
	private int width = 1;
	private int health;
	public Hp hp;
	public GameObject getMoney;

	void Update () {
		if(width == 1)
			transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(-1.15f, transform.localPosition.y, transform.localPosition.z), speed * Time.deltaTime);
		if(width == 2)
			transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(1.15f, transform.localPosition.y, transform.localPosition.z), speed * Time.deltaTime);
		if (gameObject.transform.localPosition.x >= 1.15f)
			width = 1;
		if (gameObject.transform.localPosition.x <= -1.15f)
			width = 2;
	}
	public void CheckMetka(){
		if (gameObject.transform.localPosition.x > -0.4f && gameObject.transform.localPosition.x < 0.34f) {
			hp.Well ();
			getMoney.SetActive (true);
		} else {
			health = 0;
		}
	}
	public void SpeedOne(){
		speed = 3;
	}
	public void SpeedTwo(){
		speed = 5;
	}
	public void SpeedThree(){
		speed = 10;
	}
}
