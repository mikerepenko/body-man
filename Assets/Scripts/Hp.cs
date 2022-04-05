using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UI.Image;

public class Hp : MonoBehaviour {

	GameObject bar;
	private float count;
	private bool isFood = true;
	private float timer;
	private int recordCount;
	public AudioSource use;
	public AudioSource gym;
	public AudioSource gym2;
	private int rund;
	public Metka metka;
	//public Health health;
	public Health health;

	public GameObject fine;
	public AudioSource fineSound;
	public Text record;
	public GameObject gymBtn, useBtn;
	public Ads ads;
	public GameObject gameOver;
	public bool isUse = false;
	public float timerUse;
	public GameObject man;
	public AudioSource krik;
	public AudioSource music;

	private int topNow;
	public Text top;
	public GameObject notification;

	public GameObject reviews;
	public Hand right;
	public Hand left;

	public int timerGame;
	private bool isTG;

	void Start () {
		PlayerPrefs.SetFloat("Hp", 5);
		count = PlayerPrefs.GetFloat("Hp");
		gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2(count, 20);
	}
	void FixedUpdate(){
		timer += 0.05f;
		if(timer > 110){
			isFood = true;
			timer = 0;
		}
		if (isUse) {
			timerUse += 0.05f;
			if (timerUse > 5) {
				isUse = false;
				timerUse = 0;
			}
		}
		recordCount += 1;
		if (isTG) {
			timerGame++;
			if (timerGame > 50) {
				ads.StartInterstitial ();
				gameOver.SetActive (true);
				gymBtn.SetActive (false);
				useBtn.SetActive (false);
				//man.SetActive (false);
				//Отзыв
				if (PlayerPrefs.GetInt ("Reviews") <= 5) {
					PlayerPrefs.SetInt ("Reviews", PlayerPrefs.GetInt ("Reviews") + 1);
					if (PlayerPrefs.GetInt ("Reviews") == 5) {
						reviews.SetActive (true);
					}
				}
				isTG = false;
			}
		}
	}
	public void Gym(){
		//Воспроизведение звука
		rund = Random.Range (1, 3);
		switch (rund) {
		case 1:
			gym.Play ();
			break;
		case 2:
			gym2.Play ();
			PlayerPrefs.SetInt ("Money", PlayerPrefs.GetInt ("Money") + 2);
			//Cоздание монетки со скролом
			break;
		}
		//Накаченность
		PlayerPrefs.SetFloat ("Hp", PlayerPrefs.GetFloat ("Hp") + 5f);
		//Макс накаченность
		if (PlayerPrefs.GetFloat ("Hp") > 300) {
			PlayerPrefs.SetFloat ("Hp", 300);
			Fine ();
		}
		count = PlayerPrefs.GetFloat ("Hp");
		gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (count, 20);
		//High mass
		right.HighMass();
		left.HighMass();
		//Вознаграждение
		metka.CheckMetka ();
		//Здоровье
		if (!isUse)
			health.MinusHealth ();
		else if (isUse)
			health.UseMode ();
	}
	public void Fine(){
		ads.StartInterstitial ();
		if(PlayerPrefs.GetInt ("Record") > recordCount)
			PlayerPrefs.SetInt ("Record", recordCount);
		fine.SetActive (true);
		record.text = "Время:" + " " + recordCount + "ceк";
		gymBtn.SetActive (false);
		useBtn.SetActive (false);
		man.SetActive (false);
		fineSound.Play ();
		music.Stop ();
		PlayerPrefs.SetInt ("Money",PlayerPrefs.GetInt ("Money") + 100);
		//Отзыв
		if (PlayerPrefs.GetInt ("Reviews") <= 5) {
			PlayerPrefs.SetInt ("Reviews", PlayerPrefs.GetInt ("Reviews") + 1);
			if (PlayerPrefs.GetInt ("Reviews") == 5) {
				reviews.SetActive (true);
			}
		}

		int topNow = (PlayerPrefs.GetInt("Record"));
		if (topNow < 17402) {
			int[] mas = new int[50] {
				77,
				269,
				540,
				604,
				740,
				850,
				985,
				1001,
				1002,
				1123,
				1332,
				1523,
				1931,
				1993,
				2123,
				2321,
				2521,
				2724,
				2900,
				3002,
				3021,
				3120,
				3404,
				3707,
				3918,
				4002,
				4023,
				4321,
				4508,
				4721,
				5043,
				5221,
				5704,
				6234,
				6504,
				6894,
				7121,
				7409,
				7893,
				8432,
				8700,
				9021,
				10321,
				11003,
				12392,
				13503,
				15203,
				17012,
				17402,
				topNow
			};

			//Сортировка массива
			for (int i = 0; i < 50 - 1; i++) {
				for (int j = 0; j < 50 - 1; j++) {
					if (mas [j] > mas [j + 1]) {
						int tmp = mas [j];
						mas [j] = mas [j + 1];
						mas [j + 1] = tmp;
					}
				}
			}

			for (int i = 0; i < 50 - 1; i++) {
				if (mas [i] == topNow) {
					int topPosition = i + 1;
					top.text = "Вы на " + topPosition.ToString () + " месте" + "\r\n" + "в топе";
					notification.SetActive (true);
				}
			}
		}

	}
	public void GameOver(){
		right.Kost ();
		left.Kost ();
		krik.Play ();
		music.Stop ();
		isTG = true;
	}
	public void Well(){
		PlayerPrefs.SetInt ("Money",PlayerPrefs.GetInt ("Money") + 2);
		health.PlusHealth ();
	}
	public void Use(){
		if(isFood)
		{
		use.Play();
		PlayerPrefs.SetFloat ("Hp", PlayerPrefs.GetFloat ("Hp") + 10);
		if (PlayerPrefs.GetFloat ("Hp") > 300)
			PlayerPrefs.SetFloat ("Hp", 300);
		count = PlayerPrefs.GetFloat("Hp");
		gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2(count, 20);
		health.UseMode ();
		isUse = true;
		isFood = false;
		}
	}
}
