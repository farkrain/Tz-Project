using UnityEngine;
using System.Collections;
using Newtonsoft.Json;

public class Location
{
    public string x { get; set; }
    public string y { get; set; }
}

public class Data
{
    public string type { get; set; }
    public Location location { get; set; }
    public string enemy { get; set; }
    public string battle_id { get; set; }
    public string team { get; set; }
}

public class InitiateBattleRequest
{
    public string action { get; set; }
    public Data data { get; set; }
}

public class InitiateBattle
{
    public static string Serialize(InitiateBattleRequest data)
    {
        return JsonConvert.SerializeObject(data);
    }
}