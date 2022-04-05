using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BtnMain : MonoBehaviour
{

	public MainAnim main;
	public ShopAnim shop;
	public Text price;
	public GameObject play;
	public RectTransform choose;
	public Text money;
	public GameObject backgroundShop;
	public Text score;
	public GameObject rain;
	public GameObject happy;
	private int seoClick = 0;
	//Цена на транспорт
	private int transport1 = 1000;
	private int transport2 = 5000;
	private int transport3 = 10000;
	private int transport4 = 50000;

	void Awake ()
	{
		if (PlayerPrefs.GetInt ("FirstLaunch") != 1) {
			PlayerPrefs.SetInt ("TransportLevel", 1);
			PlayerPrefs.SetInt ("Money", 1000);
			happy.SetActive(true);
			PlayerPrefs.SetInt ("FirstLaunch", 1);
			PlayerPrefs.SetFloat ("Hp", 0);
			PlayerPrefs.SetInt ("Record", 17402);
		}
		//PlayerPrefs.SetInt ("TransportLevel", 1);
		//PlayerPrefs.SetInt ("Money", 100000);

		if (PlayerPrefs.GetInt ("TransportLevel") >= PlayerPrefs.GetInt ("Choose")) {
			if (PlayerPrefs.GetInt ("Choose") == 1)
				choose.anchoredPosition = new Vector3 (-350, 0, 0);
			if (PlayerPrefs.GetInt ("Choose") == 2)
				choose.anchoredPosition = new Vector3 (0, 0, 0);
			if (PlayerPrefs.GetInt ("Choose") == 3)
				choose.anchoredPosition = new Vector3 (350, 0, 0);
			if (PlayerPrefs.GetInt ("Choose") == 3)
				choose.anchoredPosition = new Vector3 (700, 0, 0);
		} else {
			PlayerPrefs.SetInt ("Choose", 1);
			choose.anchoredPosition = new Vector3 (-350, 0, 0);
		}

		score.text = PlayerPrefs.GetInt ("Record").ToString () + "сек";
	}

	void Update ()
	{
		money.text = PlayerPrefs.GetInt ("Money").ToString ();
	}

	public void Play ()
	{
		GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
		main.Shop ();
		shop.Shop ();
		backgroundShop.SetActive (true);
		//rain.SetActive(false);
	}

	public void Score ()
	{
		GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
	}

	public void Exit ()
	{
		GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
		Application.Quit ();
	}
	public void Close()
	{
		GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
	}
	public void Click(){
		GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
	}
	public void Back ()
	{
		GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
		main.Main ();
		shop.Main ();
		backgroundShop.SetActive (false);
		//rain.SetActive(true);
	}

	public void Loading ()
	{
		GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
		SceneManager.LoadScene ("Loading");
	}

	public void Buy ()
	{
		GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
		if (PlayerPrefs.GetInt ("Choose") == 1) {
			if (PlayerPrefs.GetInt ("Money") >= transport1) {
				PlayerPrefs.SetInt ("Money", PlayerPrefs.GetInt ("Money") - transport1);
				PlayerPrefs.SetInt ("TransportLevel", 1);
				PlayerPrefs.SetInt ("Choose", 1);
				play.SetActive (true);
				PriceBtn ("");
				choose.anchoredPosition = new Vector3 (-350f, 0, 0);
				GameObject.Find ("Coin").GetComponent<AudioSource> ().Play ();
			}
		}
		if (PlayerPrefs.GetInt ("Choose") == 2) {
			if (PlayerPrefs.GetInt ("Money") >= transport2) {
				PlayerPrefs.SetInt ("Money", PlayerPrefs.GetInt ("Money") - transport2);
				PlayerPrefs.SetInt ("TransportLevel", 2);
				PlayerPrefs.SetInt ("Choose", 2);
				play.SetActive (true);
				PriceBtn ("");
				choose.anchoredPosition = new Vector3 (0, 0, 0);
				GameObject.Find ("Coin").GetComponent<AudioSource> ().Play ();
			}
		}
		if (PlayerPrefs.GetInt ("Choose") == 3) {
			if (PlayerPrefs.GetInt ("Money") >= transport3) {
				PlayerPrefs.SetInt ("Money", PlayerPrefs.GetInt ("Money") - transport3);
				PlayerPrefs.SetInt ("TransportLevel", 3);
				PlayerPrefs.SetInt ("Choose", 3);
				play.SetActive (true);
				PriceBtn ("");
				choose.anchoredPosition = new Vector3 (350, 0, 0);
				GameObject.Find ("Coin").GetComponent<AudioSource> ().Play ();
			}
		}
		if (PlayerPrefs.GetInt ("Choose") == 4) {
			if (PlayerPrefs.GetInt ("Money") >= transport4) {
				PlayerPrefs.SetInt ("Money", PlayerPrefs.GetInt ("Money") - transport4);
				PlayerPrefs.SetInt ("TransportLevel", 4);
				PlayerPrefs.SetInt ("Choose", 4);
				play.SetActive (true);
				PriceBtn ("");
				choose.anchoredPosition = new Vector3 (700, 0, 0);
				GameObject.Find ("Coin").GetComponent<AudioSource> ().Play ();
			}
		}
	}

	//Первый транспорт
	public void Choose1 ()
	{
		PlayerPrefs.SetInt ("Choose", 1);
		GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
		if (PlayerPrefs.GetInt ("TransportLevel") >= 1) {
			play.SetActive (true);
			PriceBtn ("");
			choose.anchoredPosition = new Vector3 (-350f, 0, 0);

		} else {
			PriceBtn ("1000");
			play.SetActive (false);
		}
	}
	//Второй транспорт
	public void Choose2 ()
	{
		PlayerPrefs.SetInt ("Choose", 2);
		GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
		Debug.Log (PlayerPrefs.GetInt ("TransportLevel"));
		if (PlayerPrefs.GetInt ("TransportLevel") >= 2) {
			play.SetActive (true);
			PriceBtn ("");
			choose.anchoredPosition = new Vector3 (0, 0, 0);
		} else {
			PriceBtn ("5000");
			play.SetActive (false);
		}
	}
	//Третий транспорт
	public void Choose3 ()
	{
		PlayerPrefs.SetInt ("Choose", 3);
		GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
		if (PlayerPrefs.GetInt ("TransportLevel") >= 3) {
			play.SetActive (true);
			PriceBtn ("");
			choose.anchoredPosition = new Vector3 (350, 0, 0);
		} else {
			PriceBtn ("10000");
			play.SetActive (false);
		}
	}

	public void Choose4 ()
	{
		PlayerPrefs.SetInt ("Choose", 4);
		GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
		if (PlayerPrefs.GetInt ("TransportLevel") >= 4) {
			play.SetActive (true);
			PriceBtn ("");
			choose.anchoredPosition = new Vector3 (700, 0, 0);
		} else {
			PriceBtn ("50000");
			play.SetActive (false);
		}
	}

	public void PriceBtn (string m)
	{
		price.text = m;
	}
	public void BtnSeo()
	{
			seoClick += 1;
			if (seoClick >= 10)
				SceneManager.LoadScene ("Seo");
	}
}
