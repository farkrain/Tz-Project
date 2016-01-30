using UnityEngine;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Sockets;
using UnityEngine.SceneManagement;

public class ConnectServer : MonoBehaviour 
{
	public static string res;
	public static StreamWriter strwrite;
	public static StreamReader strread; 
	void Start()
	{ 
		ConnectClient();
		DontDestroyOnLoad(gameObject.transform);
	}
	void ConnectClient()
	{
		TcpClient tcpClient = new TcpClient();
		tcpClient.Connect ("cr0.nz", 25564);
		NetworkStream stream = tcpClient.GetStream ();
		strwrite = new StreamWriter (stream);
		strread = new StreamReader (stream);
	}
	public static void SendLogin(string name)
	{
		strwrite.WriteLine (name);
		strwrite.Flush ();
		Debug.Log ("Логин отправлен");
		res = strread.ReadLine ();
		Debug.Log(res.ToString());
	}
}

