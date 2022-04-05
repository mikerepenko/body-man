using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hand : MonoBehaviour {

	public float speedRotate;
	private string isHand;
	private int isGym = 3;
	public Sprite kost;
	public float count;

	private int gym = 1;
	public GameObject go;
	private bool isGo;
	public float speed;

	public Health health;
	public float f;

	void Start(){
		if (gameObject.name == "Right")
			isHand = "right";
		if (gameObject.name == "Left")
			isHand = "left";
		count = 50;
		gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (100, count);
	}
	void Update(){
		if (isHand == "right") {
			if (isGym == 1)
				transform.Rotate(0, 0, speedRotate * Time.deltaTime / 0.1f);
			else if(isGym == 2)
				transform.Rotate(0, 0, -speedRotate * Time.deltaTime / 0.1f);

			if (transform.localRotation.z >= 0.75f)
				health.MinusRotate ();
			else
				health.RotateOff ();
		}
		if (isHand == "left") {
			if (isGym == 1)
				transform.Rotate(0, 0, -speedRotate * Time.deltaTime / 0.1f);
			else if(isGym == 2)
				transform.Rotate(0, 0, speedRotate * Time.deltaTime / 0.1f);
			
			if (transform.localRotation.z <= -0.75f)
				health.MinusRotate ();
			else
				health.RotateOff ();
		}
		if(isGo)
			transform.localPosition = Vector3.MoveTowards (transform.localPosition, new Vector3 (transform.position.x, -450f, transform.localPosition.z), speed * Time.deltaTime);
	}
	void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.tag == "Up") {
			isGym = 2;
			Debug.Log ("Сработало");
		}
		if (c.gameObject.tag == "Down")
			isGym = 3;
	}
	public void Gym(){
		isGym = gym;
	}
	public void HighMass(){
		count += 3f;
		gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (100, count);
		if (count >= 150f)
			count = 150f;
	}
	public void Kost(){
		gameObject.GetComponent<Image> ().sprite = kost;
		isGo = true;
		gym = 2;
		isGym = 2;
		speedRotate = 2f;
		go.SetActive (false);
	}
}
