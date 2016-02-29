using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MouseTarget : MonoBehaviour {
	public SpriteRenderer targetSprite;
	public Object obj;
	private static MouseTarget mInstance;
	public static MouseTarget instance {
		get { return mInstance; }
	}
	private bool objSelected;


	// Use this for initialization
	void Start () {
		if (mInstance == null) {
			mInstance = this;
		}
		objSelected = false;
	}

	public void TargetChosen(bool chosen){
		objSelected = chosen;
		if (chosen) {
			targetSprite.color = Color.red;
			Debug.Log ("mouse target is chosen");
		} else {
			targetSprite.color = Color.white;
			Debug.Log ("mouse target is not chosen");
		}
	}

	public void instantiateObj() {
		Debug.Log ("instatiateObj() called");
		Vector3 position = transform.position;
		if (!objSelected) {
			Instantiate (obj, position, Quaternion.identity);
		}
	}
}
