using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

public class InitiateBattleResponse 
{
    public string status { get; set; }
    public BodyBattleResponse body { get; set; }
}
public class TypeBattleResponse
{
    public string type { get; set; }
    public string data { get; set; }
}

public class BodyBattleResponse
{
    public string battle_id { get; set; }
    public List<TypeBattleResponse> data { get; set; }
}

public class ResponseInitiateBattle
{
    public static InitiateBattleResponse Deserialize(string data)
    {
        return JsonConvert.DeserializeObject<InitiateBattleResponse>(data);
    }
}

public class TypeBattleResponsePlayerPosition
{
    public Position position { get; set; }
}

public class TypeBattleResponseMapInfo
{
    public int terrain { get; set; }
    public List<Decorations> decorations { get; set; }
}

public class TypeBattleResponseUnits
{
    public string type { get; set; }
    public int idUnit { get; set; }
    public Position position { get; set; }
    public int team { get; set; }
    public int max_hp { get; set; }
    public int hp { get; set; }
    public int level { get; set; }
    public string name { get; set; }
    public int state { get; set; }
    public Stats stats { get; set; }
    public List<Item> items { get; set; }
}

public class TypeBattleResponseEffects
{
    public int idEffect { get; set; }
    public Position position { get; set; }
}

public class TypeBattleResponseDrops
{
    public int idBox { get; set; }
    public Position position { get; set; }
    public List<Item> items { get; set; }
}

public class Position
{
    public int x { get; set; }
    public int y { get; set; }
}

public class Decorations
{
    public int id_dicartion { get; set; }
    public Position position { get; set; }
    public int state { get; set; }
}

public class Stats
{
    public int stamina { get; set; }
    public int agility { get; set; }
    public int intelligence { get; set; }
}

public class Item
{
    public string type { get; set; }
    public int idItem { get; set; }
    public int qty { get; set; }
}
