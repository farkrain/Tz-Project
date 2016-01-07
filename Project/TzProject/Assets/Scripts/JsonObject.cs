using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

public class JsonObject {
	public List<Message> message { get; set; }
}

public class CoordinatesMove
{
	public int x { get; set; }
	public int y { get; set; }
}

public class CoordinatesTarget
{
	public int x { get; set; }
	public int y { get; set; }
}

public class Target
{
	public string type { get; set; }
	public CoordinatesTarget coordinates { get; set; }
}

public class Data2
{
	public CoordinatesMove coordinates { get; set; }
	public string new_position { get; set; }
	public Target target { get; set; }
}

public class Seq
{
	public string action { get; set; }
	public Data1 data { get; set; }
}

public class Data1
{
	public List<Seq> seq { get; set; }
}

public class Message
{
	public string player { get; set; }
	public string action { get; set; }
	public Data1 data { get; set; }
}


public class ActionTurn
{
	public static string Serialize(JsonObject data)
	{
		return JsonConvert.SerializeObject (data);
	}
	public static JsonObject Deserialize(string data)
	{
		return JsonConvert.DeserializeObject<JsonObject> (data);
	}
}



