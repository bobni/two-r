using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MouseTarget : MonoBehaviour {
	public SpriteRenderer targetSprite;


	// Use this for initialization
	void Start () {
	
	}
	
	public void TargetChosen(bool chosen){
		if (chosen) {
			targetSprite.color = Color.white;
		} else {
			targetSprite.color = Color.red;
		}
	}
}
