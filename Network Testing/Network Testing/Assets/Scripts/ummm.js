﻿#pragma strict

var remoteIP = "127.0.0.1";
var remotePort = 25000;
var listenPort = 25000;
var useNAT = false;
var yourIP = "";
var yourPort = "";

function Start () {

}

function Update () {

}


function OnGUI () {
 // Checking if you are connected to the server or not
 if (Network.peerType == NetworkPeerType.Disconnected)
 {
 // If not connected

 if (GUI.Button (new Rect(10,10,100,30),"Connect"))
 {
 Network.useNat = useNAT;
 // Connecting to the server
 Network.Connect(remoteIP, remotePort);
 }
 if (GUI.Button (new Rect(10,50,100,30),"Start Server"))
 {
 Network.useNat = useNAT;
 // Creating server
 Network.InitializeServer(32, listenPort);

 // Notify our objects that the level and the network is ready
 for (var go : GameObject in FindObjectsOfType(GameObject))
 {
 go.SendMessage("OnNetworkLoadedLevel",
SendMessageOptions.DontRequireReceiver);
 }
 }

 // Fields to insert ip address and port
 remoteIP = GUI.TextField(new Rect(120,10,100,20),remoteIP);
 remotePort = parseInt(GUI.TextField(new
Rect(230,10,40,20),remotePort.ToString()));
 }
 else
 {
 // Getting your ip address and port
 var ipaddress = Network.player.ipAddress;
 var port = Network.player.port.ToString();

 GUI.Label(new Rect(140,20,250,40),"IP Adress: "+ipaddress+":"+port);
 if (GUI.Button (new Rect(10,10,100,50),"Disconnect"))
 {
 // Disconnect from the server
 Network.Disconnect(200);
 }
 }
}