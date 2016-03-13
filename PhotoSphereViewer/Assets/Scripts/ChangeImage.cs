using UnityEngine;
using System.Collections;
using System; 

public class ChangeImage : MonoBehaviour {

	public Texture defaultTexture;
	public string url = "http://i.imgur.com/hXen5YC.jpg";

	IEnumerator Start() {
		// Start a download of the given URL
		try{
			storeImage storeThis = GameObject.FindGameObjectWithTag("store").GetComponent<storeImage>();
			url = storeThis.stored;
		} catch {
			
		}

		if (!url.StartsWith("http"))
			url = "http://droidviews.com/wp-content/uploads/2013/06/Photosphere-Photo.jpg";
		WWW www = new WWW (url);

		// Wait for download to complete
		Renderer renderer = GetComponent<Renderer> ();

		if (!string.IsNullOrEmpty (www.error)) {
			Debug.Log(www.error);
			renderer.material.mainTexture = defaultTexture;
		} else {
			yield return www;
			// assign texture
			renderer.material.mainTexture = www.texture;
		}

	}

	public void changeRoom(string newURL) {
		// Start a download of the given URL
		Debug.Log ("changing URL");
		url = newURL;
		Start ();

	}
}
