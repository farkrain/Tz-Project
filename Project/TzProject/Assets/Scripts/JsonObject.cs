using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

public class JsonObject {
}
public class Coordinates2
{
	public int x { get; set; }
	public int y { get; set; }
}

public class Target
{
	public string type { get; set; }
	public Coordinates2 coordinates { get; set; }
}
public class Coordinates
{
	public int x { get; set; }
	public int y { get; set; }
}

public class Data
{
	public Coordinates coordinates { get; set; }
	public string new_position { get; set; }
	public Target target { get; set; }
}

public class Seq
{
	public string action { get; set; }
	public Data data { get; set; }
}

public class Turn
{
	public List<Seq> seq { get; set; }
}

public class RootObject
{
	public string action { get; set; }
	public Turn turn { get; set; }
}

public class ActionTurn
{
	public static string Serialize(RootObject data)
	{
		return JsonConvert.SerializeObject (data);
	}
	public static RootObject Deserialize(string data)
	{
		return JsonConvert.DeserializeObject<RootObject> (data);
	}
}



