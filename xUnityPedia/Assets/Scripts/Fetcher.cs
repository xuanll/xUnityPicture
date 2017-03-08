using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fetcher : MonoBehaviour {

	private IEnumerator coroutine;

	public void LoadPictureToImage(string url, Image image){
		coroutine = GetTextureFromURL (url, image);

		StartCoroutine(coroutine);
	}
		

	private IEnumerator GetTextureFromURL(string url, Image image){
		WWW www = new WWW(url);
		yield return www;

		if(www != null && string.IsNullOrEmpty(www.error))
		{
			Texture2D texture=www.texture;

			Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

			RectTransform rt = image.transform.GetComponent<RectTransform> ();
			rt.sizeDelta = new Vector2 (texture.width, texture.height);
			rt.localScale = Vector3.one;

			image.sprite = sprite;
		}
	}
}
