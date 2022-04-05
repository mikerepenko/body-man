using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AppodealAds.Unity.Common;
using AppodealAds.Unity.Api;

public class Ads : MonoBehaviour, IRewardedVideoAdListener {

		#region Rewarded Video callback handlers
		public void onRewardedVideoLoaded() { print("Video loaded"); }
		public void onRewardedVideoFailedToLoad() { print("Video failed"); }
		public void onRewardedVideoShown() { print("Video shown"); }
		public void onRewardedVideoClosed(bool finished) { print("Video closed"); }
		public void onRewardedVideoFinished(int amount, string name) { print("Reward: " + amount + " " + name);
				PlayerPrefs.SetInt ("Money", PlayerPrefs.GetInt ("Money") + 500);
				finished.SetActive(true);
		}
		#endregion

		public GameObject finished;
		private int countGameover;

		void Awake()
    {
		//StopAds ();
		//Подключение Appodeal
		string appKey = "1acb702a324152c1f64fda3ae28df9b2c4e7195742926b4b";
		Appodeal.disableLocationPermissionCheck();
		//Appodeal.setTesting(true);
		Appodeal.initialize(appKey, Appodeal.REWARDED_VIDEO | Appodeal.INTERSTITIAL);
		Appodeal.setRewardedVideoCallbacks(this);

		countGameover = PlayerPrefs.GetInt("CGO");
    }
		public void StartCallBack()
    {
				GameObject.Find ("Click").GetComponent<AudioSource> ().Play ();
       //Проверка наличия интернета
        if(Appodeal.isLoaded(Appodeal.REWARDED_VIDEO))
            Appodeal.show(Appodeal.REWARDED_VIDEO);
    }
    public void StartInterstitial()
    {
		countGameover++;
		if (PlayerPrefs.GetInt("CGO") <= 100)
			PlayerPrefs.SetInt("CGO", countGameover);
		else
			PlayerPrefs.SetInt("CGO", 0);
		if (countGameover % 3 == 0) {
			if (Appodeal.isLoaded (Appodeal.INTERSTITIAL))
				Appodeal.show (Appodeal.INTERSTITIAL);
		}
    }
	/*public void StopAds()
	{
		Appodeal.hide(Appodeal.INTERSTITIAL);
	}
    public void StartBanner()
    {
        if (Appodeal.isLoaded(Appodeal.BANNER_BOTTOM))
            Appodeal.show(Appodeal.BANNER_BOTTOM);
    }
		public void OffAds(){
				Appodeal.hide(Appodeal.BANNER_BOTTOM);
        Appodeal.hide(Appodeal.INTERSTITIAL);
		}*/
}
