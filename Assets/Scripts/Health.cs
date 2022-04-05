using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Health : MonoBehaviour {

	private float count = 160;
	private float deltaCount;
	//public GameObject gameOver;
	private float max = 160;
	public Hp hp;
	public Metka metka;

	public GameObject rotate;
	public bool isRotate = true;

	void Start () {
		gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2(count, 20);
	}
	void Update(){
		count += 0.3f;
		if (count > max)
			count = max;
		gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2(count, 20);
		//Проверка для скорости
		if (count >= 95)
			metka.SpeedOne ();
		else if (count >= 30)
			metka.SpeedTwo ();
		else if (count >= -50)
			metka.SpeedThree ();
	}
	public void MinusRotate(){
		rotate.SetActive (true);
		deltaCount = 1;
		count = count - deltaCount;
		if (count < -50) {
			count = -50;
			if (isRotate) {
				hp.GameOver ();
				isRotate = false;
			}
			rotate.SetActive (false);
		}
		gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2(count, 20);
	}
	public void RotateOff(){
		//rotate.SetActive (false);
	}
	public void MinusHealth(){
		deltaCount = 45;
		count = count - deltaCount;
		if (count < -50) {
			count = -50;
			hp.GameOver ();
		}
		gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2(count, 20);
		gameObject.GetComponent<Image>().color = new Color32(255,0,5,255);
	}
	public void PlusHealth(){
		deltaCount = 45;
		count = count + deltaCount;
		if (count > max)
			count = max;
		gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2(count, 20);
	}
	public void UseMode(){
		gameObject.GetComponent<Image>().color = new Color32(0,255,44,255);
	}
}
