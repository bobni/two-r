using UnityEngine;
using System.Collections;

public class NetworkingThings : MonoBehaviour {
	public string remoteIP = "127.0.0.1";
	public int remotePort = 25000;
	public int listenPort = 25000;
	public bool useNAT = false;
	public string yourIP = "";
	public string yourPort = "";


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI () {
		// Checking if you are connected to the server or not
		if (Network.peerType == NetworkPeerType.Disconnected){
			// If not connected

			if (GUI.Button (new Rect(10,10,100,30),"Connect")){
				Network.useNat = useNAT;
				// Connecting to the server
				Network.Connect(remoteIP, remotePort);
			}

			if (GUI.Button (new Rect(10,50,100,30),"Start Server")){
				Network.useNat = useNAT;
				// Creating server
				Network.InitializeServer(32, listenPort);


				GameObject[] objs = FindObjectsOfType(typeof(GameObject)) as GameObject[];

				// Notify our objects that the level and the network is ready
				foreach (GameObject go in objs){
					go.SendMessage("OnNetworkLoadedLevel",
						SendMessageOptions.DontRequireReceiver);
				}
			}

			// Fields to insert ip address and port
			remoteIP = GUI.TextField(new Rect(120,10,100,20),remoteIP);
			string rp = GUI.TextField (new Rect (230, 10, 40, 20), remotePort.ToString ());
			if (!System.Int32.TryParse (rp, out remotePort)) {
				Debug.Log("there was a error in Network.cs");
			}

			//			remotePort = int.TryParse(rp);
		} else {
			// Getting your ip address and port
			string ipaddress = Network.player.ipAddress;
			string port = Network.player.port.ToString();

			GUI.Label(new Rect(140,20,250,40),"IP Adress: "+ipaddress+":"+port);
			if (GUI.Button (new Rect(10,10,100,50),"Disconnect")){
				// Disconnect from the server
				Network.Disconnect(200);
			}
		}
	}

	void OnConnectedToServer () {
		// Notify our objects that the level and the network are ready
		GameObject[] objs = FindObjectsOfType (typeof(GameObject)) as GameObject[];

		foreach (GameObject go in objs) {
			go.SendMessage ("OnNetworkLoadedLevel",
				SendMessageOptions.DontRequireReceiver);
		}
	}




}
