using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour {
	void Start() {
		Debug.Log ("here");
		foreach (string device in Microphone.devices) {
			Debug.Log("Name: " + device);
		}
	}
}