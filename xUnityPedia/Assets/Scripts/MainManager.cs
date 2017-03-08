using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class MainManager : MonoBehaviour {

	[SerializeField]
	private Image image; 

	void OnEnable(){
		string smatisan_logo = "http://t.cn/Ri0b37C"; 		//shorten by http://dwz.wailian.work/
		string smatisan_cloud = "http://t.cn/Ri0GhGZ";

		string yougForYou_logo = "http://t.cn/RiW2K6q"; 

		// Fetcher 
		if (image != null) {
			if (image.transform.GetComponent<Fetcher> () != null)
				image.transform.GetComponent<Fetcher> ().LoadPictureToImage (smatisan_cloud, image);
			else
				image.gameObject.AddComponent<Fetcher> ().LoadPictureToImage (smatisan_logo, image);
		} else {
			Debug.Log ("Image is null, please check..");

			GameObject go = new GameObject ("image");

			// set Parent
			go.transform.SetParent (transform);

			// add Image component
			go.AddComponent<Image> ();

			// set the position
			go.transform.localPosition = Vector3.zero;

			//set image to newly created Image
			image = go.GetComponent<Image>();

			// add Fetcher and load picture
			go.AddComponent<Fetcher>().LoadPictureToImage (yougForYou_logo, image);
		}
	}
}
