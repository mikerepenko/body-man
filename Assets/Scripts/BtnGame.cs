using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnGame : MonoBehaviour {

	public Text money;
	public Text score;
	public GameObject rewiews;

	void Update ()
	{
		money.text = PlayerPrefs.GetInt ("Money").ToString ();
		score.text = PlayerPrefs.GetInt ("Record").ToString () + "сек";

	}
	public void Shop ()
	{
		GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
		SceneManager.LoadScene ("Main");
	}
	public void Replay()
	{
		GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
		SceneManager.LoadScene ("Game");
	}
	public void Click(){
		GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
	}
	public void Reviews(){
		Application.OpenURL("https://play.google.com/store/apps/details?id=com.newsgames.bodyman");
		PlayerPrefs.SetInt ("Money",PlayerPrefs.GetInt ("Money") + 1000);
		rewiews.SetActive (false);
	}
}
