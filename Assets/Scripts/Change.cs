using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI.Image;
using UnityEngine.UI;

public class Change : MonoBehaviour {

	public Sprite food, protein, sintol, nasos;

	void Start () {
		if(PlayerPrefs.GetInt ("Choose") == 1)
			this.GetComponent<Image> ().sprite = food;
		if(PlayerPrefs.GetInt ("Choose") == 2)
			this.GetComponent<Image> ().sprite = protein;
		if(PlayerPrefs.GetInt ("Choose") == 3)
			this.GetComponent<Image> ().sprite = sintol;
		if(PlayerPrefs.GetInt ("Choose") == 4)
			this.GetComponent<Image> ().sprite = nasos;
	}
}
