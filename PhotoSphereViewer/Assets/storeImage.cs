using UnityEngine;
using System.Collections;

public class storeImage : MonoBehaviour {
	public string stored = "";
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
		this.transform.localScale = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void storeValue(string storeThis)
	{
		stored = storeThis;
	}

}
