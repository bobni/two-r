using UnityEngine;
using System.Collections;

public class ChangeImage : MonoBehaviour {

	public Texture defaultTexture;
	public string thisUrl = "http://i.imgur.com/f5mqp.jpg";

	IEnumerator Start() {
		// Start a download of the given URL
		storeImage storeThis = GameObject.FindGameObjectWithTag("store").GetComponent<storeImage>();
		string url = storeThis.stored;
		if (storeThis == null || !url.StartsWith("http"))
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
}
