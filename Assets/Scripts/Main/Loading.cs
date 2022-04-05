using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {

	private int rund;
	public Text comment;
	public float timer;
	private bool isChange;
	private string firstText;

	void Start(){
		rund = Random.Range(1, 6);
		switch (rund) {
		case 1:
			comment.text = "Парень добирается на метро.";
			break;
		case 2:
			comment.text = "Восстанавливается.";
			break;
		case 3:
			comment.text = "Колется перед качалкой.";
			break;
		case 4:
			comment.text = "Одевается в качалку.";
			break;
		case 5:
			comment.text = "Разговаривает с друзьями.";
			break;
		}
		firstText = comment.text;
 	}
	void FixedUpdate(){
		timer += Time.deltaTime;
		if (!isChange) {
			if (timer > 0.8 && timer < 2 || timer > 3) {
				comment.text = comment.text + "..";
				isChange = true;
			}
		} else if (isChange) {
			if (timer > 2 && timer < 3) {
				comment.text = firstText;
				isChange = false;
			}
		}
		if (timer > 5)
			SceneManager.LoadScene ("Game");
	}
}
