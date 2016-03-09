using UnityEngine;
using System.Collections;

public class loadOnClick : MonoBehaviour {

	//public GameObject loadingImage;
	public string stringToEdit = "Hello World";
	public GUIStyle input;
	public ScriptableObject storer;
	void OnGUI() {
		input.fontSize = 30;
		input.alignment = TextAnchor.MiddleCenter;
		input.border = new RectOffset (1, 1, 1, 1);

		stringToEdit = GUI.TextField(new Rect(Screen.width/2-110, Screen.height/2+20, 220, 30), stringToEdit, input);
	}
	public void LoadScene(int level)
	{
		//loadingImage.SetActive(true);
		storeImage storeThis = GameObject.FindGameObjectWithTag("store").GetComponent<storeImage>();
		storeThis.stored = stringToEdit;
		Application.LoadLevel(level);
	}
}