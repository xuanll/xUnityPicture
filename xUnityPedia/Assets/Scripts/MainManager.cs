using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class MainManager : MonoBehaviour {

	[SerializeField]
	private Image image; 

	void OnEnable(){
		string smatisan_logo = "http://t.cn/Ri0b37C"; 		//shorten by http://dwz.wailian.work/
		string smatisan_cloud = "http://t.cn/Ri0GhGZ";

		// Fetcher 
		if (image != null) {
			if (image.transform.GetComponent<Fetcher> () != null)
				image.transform.GetComponent<Fetcher> ().LoadPictureToImage (smatisan_cloud, image);
			else
				image.gameObject.AddComponent<Fetcher> ().LoadPictureToImage (smatisan_logo, image);
		} else {
			Debug.Log ("Image is null, please check..");
		}
		
	}
}
