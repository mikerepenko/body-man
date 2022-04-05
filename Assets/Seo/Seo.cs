using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AppodealAds.Unity.Common;
using AppodealAds.Unity.Api;

public class Seo : MonoBehaviour, IRewardedVideoAdListener {

		#region Rewarded Video callback handlers
		public void onRewardedVideoLoaded() { print("Video loaded"); }
		public void onRewardedVideoFailedToLoad() { print("Video failed"); }
		public void onRewardedVideoShown() { print("Video shown"); }
		public void onRewardedVideoClosed(bool finished) { print("Video closed"); }
		public void onRewardedVideoFinished(int amount, string name) { print("Reward: " + amount + " " + name);

		}
		#endregion

		void Awake()
    {
		//Подключение Appodeal
		string appKey = "0c42a67ae03adf56ac9f3d9d4ffee4147d61c789cc2a7435";
		Appodeal.disableLocationPermissionCheck();
		//Appodeal.setTesting(true);
		Appodeal.initialize(appKey, Appodeal.REWARDED_VIDEO | Appodeal.INTERSTITIAL);
		Appodeal.setRewardedVideoCallbacks(this);
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
        if (Appodeal.isLoaded(Appodeal.INTERSTITIAL))
            Appodeal.show(Appodeal.INTERSTITIAL);
    }
		public void StartBanner()
    {
        if (Appodeal.isLoaded(Appodeal.BANNER_BOTTOM))
            Appodeal.show(Appodeal.BANNER_BOTTOM);
    }
		public void StopBanner()
    {
        Appodeal.hide(Appodeal.INTERSTITIAL);
    }



		public void OffAds(){
				Appodeal.hide(Appodeal.BANNER_BOTTOM);
        Appodeal.hide(Appodeal.INTERSTITIAL);
		}
}
