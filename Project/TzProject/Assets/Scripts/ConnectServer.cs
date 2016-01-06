using UnityEngine;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;

public class ConnectServer : MonoBehaviour 
{
	public string res;
	void Start ()
	{ 
		ConnectClient();
	}
	void ConnectClient()
	{
		TcpClient tcpClient = new TcpClient();
		tcpClient.Connect ("cr0.nz", 25564);
		NetworkStream stream = tcpClient.GetStream ();
		StreamWriter strwrite = new StreamWriter (stream);
		StreamReader strread = new StreamReader (stream);
		strwrite.WriteLine ("123");
		strwrite.Flush ();
		Debug.Log ("Логин отправлен");
		res = strread.ReadLine ();
		Debug.Log(res.ToString());

	}
}