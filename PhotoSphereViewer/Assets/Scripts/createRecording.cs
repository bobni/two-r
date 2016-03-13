using UnityEngine;
using System.Collections;

public class createRecording : MonoBehaviour {
	public GameObject recordObject;
	public GameObject pointer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void createRecordObject () {
		Debug.Log ("creating note");
		Instantiate(recordObject, pointer.transform.position+(pointer.transform.forward*9), pointer.transform.rotation);
	}
}
