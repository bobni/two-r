using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class SwitchImage : MonoBehaviour {

	//public Renderer skybox =  Camera.main.gameObject.GetComponent<Skybox>();
	public Texture t1;
	public Texture t2;
	public Texture t3;
	private int currentTexture = 0;
	Renderer renderer;
	public GameObject sphere;


	// Use this for initialization
	void Start () {
		renderer = sphere.GetComponent<Renderer> ();
	}

	public void switchBackgroundImage() {
		Debug.Log ("switchBackgroundImageusing UnityEngine;\nusing System.Collections;\n\npublic class NetworkScript : MonoBehaviour {\n\tpublic string remoteIP = \"127.0.0.1\";\n\tpublic int remotePort = 25000;\n\tpublic int listenPort = 25000;\n\tpublic bool useNAT = false;\n\tpublic string yourIP = \"\";\n\tpublic string yourPort = \"\";\n\n\n\t// Use this for initialization\n\tvoid Start () {\n\t\n\t}\n\t\n\t// Update is called once per frame\n\tvoid Update () {\n\t\n\t}\n\n\tvoid OnGUI () {\n\t\t// Checking if you are connected to the server or not\n\t\tif (Network.peerType == NetworkPeerType.Disconnected){\n\t\t\t// If not connected\n\n\t\t\tif (GUI.Button (new Rect(10,10,100,30),\"Connect\")){\n\t\t\t\tNetwork.useNat = useNAT;\n\t\t\t\t// Connecting to the server\n\t\t\t\tNetwork.Connect(remoteIP, remotePort);\n\t\t\t}\n\n\t\t\tif (GUI.Button (new Rect(10,50,100,30),\"Start Server\")){\n\t\t\t\tNetwork.useNat = useNAT;\n\t\t\t\t// Creating server\n\t\t\t\tNetwork.InitializeServer(32, listenPort);\n\t\t\t\n\n\t\t\t\tGameObject[] objs = FindObjectsOfType(typeof(GameObject)) as GameObject[];\n\n\t\t\t\t// Notify our objects that the level and the network is ready\n\t\t\t\tforeach (GameObject go in objs){\n\t\t\t\t\tgo.SendMessage(\"OnNetworkLoadedLevel\",\n\t\t\t\t\t\tSendMessageOptions.DontRequireReceiver);\n\t\t\t\t}\n\t\t\t}\n\n\t\t\t// Fields to insert ip address and port\n\t\t\tremoteIP = GUI.TextField(new Rect(120,10,100,20),remoteIP);\n\t\t\tstring rp = GUI.TextField (new Rect (230, 10, 40, 20), remotePort.ToString ());\n\t\t\tif (!System.Int32.TryParse (rp, out remotePort)) {\n\t\t\t\tDebug.Log(\"there was a error in Network.cs\");\n\t\t\t}\n\n//\t\t\tremotePort = int.TryParse(rp);\n\t\t} else {\n\t\t\t// Getting your ip address and port\n\t\t\tstring ipaddress = Network.player.ipAddress;\n\t\t\tstring port = Network.player.port.ToString();\n\n\t\t\tGUI.Label(new Rect(140,20,250,40),\"IP Adress: \"+ipaddress+\":\"+port);\n\t\t\tif (GUI.Button (new Rect(10,10,100,50),\"Disconnect\")){\n\t\t\t\t// Disconnect from the server\n\t\t\t\tNetwork.Disconnect(200);\n\t\t\t}\n\t\t}\n\t}\n\n\tvoid OnConnectedToServer () {\n\t\t// Notify our objects that the level and the network are ready\n\t\tGameObject[] objs = FindObjectsOfType (typeof(GameObject)) as GameObject[];\n\n\t\tforeach (GameObject go in objs) {\n\t\t\tgo.SendMessage (\"OnNetworkLoadedLevel\",\n\t\t\t\tSendMessageOptions.DontRequireReceiver);\n\t\t}\n\t}\n\n\n\n\n}\n has been clicked!"); 
		Debug.Log (currentTexture);
		switch (currentTexture) {
		case 0:
			renderer.material.mainTexture = t2;
			currentTexture++;
			break;
		case 1:
			renderer.material.mainTexture = t3;
			currentTexture++;
			break;
		case 2:
			renderer.material.mainTexture = t1;
			currentTexture = 0;
			break;	
		}
	}
}
