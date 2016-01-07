using UnityEngine;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Sockets;

public class ConnectServer : MonoBehaviour 
{
	public string res;
	void Start ()
	{ 
		ConnectClient();
		DontDestroyOnLoad(gameObject.transform);
	}
	void ConnectClient()
	{
		TcpClient tcpClient = new TcpClient();
		tcpClient.Connect ("cr0.nz", 25564);
		NetworkStream stream = tcpClient.GetStream ();
		StreamWriter strwrite = new StreamWriter (stream);
		StreamReader strread = new StreamReader (stream);
		JsonObject data = ActionTurn.Deserialize("{\"action\":\"battle_turn\",\"turn\":{\"seq\":[{\"action\":\"battle_player_move\",\"data\":{\"coordinates\":{\"x\":10,\"y\":15}}},{\"action\":\"battle_player_change_position\",\"data\":{\"new_position\":\"2\"}},{\"action\":\"battle_player_shoot\",\"data\":{\"target\":{\"type\":\"area\",\"coordinates\":{\"x\":12,\"y\":17}}}}]}}");
		Debug.Log (data);
		strwrite.WriteLine (ActionTurn.Serialize(data));
		strwrite.Flush ();
		Debug.Log ("Логин отправлен");
		res = strread.ReadLine ();
		Debug.Log(res.ToString());
	}
}

