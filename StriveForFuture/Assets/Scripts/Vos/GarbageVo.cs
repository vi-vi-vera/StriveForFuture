using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class GarbageVo
{
    int id;
    string name;
    int maxCount;
    string description;
    string type;
    int num;//当前叠加数量

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public int MaxCount { get => maxCount; set => maxCount = value; }
    public string Description { get => description; set => description = value; }
    public string Type { get => type; set => type = value; }
    public int Num { get => num; set => num = value; }

    public GarbageVo(int id, string name, int maxCount, string description, string type, int num)
    {
        this.id = id;
        this.name = name;
        this.maxCount = maxCount;
        this.description = description;
        this.type = type;
        this.num = num;
    }

    public GarbageVo(XmlElement item)
    {
        id = int.Parse(item.GetAttribute("id"));
        name = item.GetAttribute("name");
        maxCount = int.Parse(item.GetAttribute("maxCount"));
        description = item.GetAttribute("description");
        type = item.GetAttribute("type");
        num = 1;
    }

    public GarbageVo(GarbageVo garbage)
    {
        this.id = garbage.id;
        this.name = garbage.name;
        this.maxCount = garbage.maxCount;
        this.description = garbage.description;
        this.type = garbage.type;
        this.num = garbage.num;
    }

    public GarbageVo Clone()
    {
        GarbageVo garbage = new GarbageVo(this);
        return garbage;
    }
}
