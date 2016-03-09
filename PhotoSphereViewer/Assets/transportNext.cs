using UnityEngine;
using System.Collections;

public class transportNext : MonoBehaviour {
	public string url = "http://i.imgur.com/f5mqp.jpg";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void nextRoom(){
		Debug.Log ("let's go");
		//if(!url.StartsWith("http"))
		//	url = "http://droidviews.com/wp-content/uploads/2013/06/Photosphere-Photo.jpg";
		ChangeImage next = GameObject.FindGameObjectWithTag ("photosphere").GetComponent<ChangeImage> ();
		next.changeRoom ( url );
	}

}
