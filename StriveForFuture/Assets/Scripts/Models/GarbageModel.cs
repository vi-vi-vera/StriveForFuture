using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System;

public class GarbageModel
{
    private static GarbageModel _instance = null;

    private GarbageModel()
    {

    }

    public static GarbageModel Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new GarbageModel();
            }
            return _instance;
        }
    }

    Dictionary<int, GarbageVo> garbageDict = new Dictionary<int, GarbageVo>();//用来存储Xml解析出来的数据（数据源）
    List<GarbageVo> bagList = new List<GarbageVo>();//背包真实的数据

    public GarbageVo GetGarbageById(int id)
    {
        if (garbageDict.ContainsKey(id))
        {
            return garbageDict[id];
        }
        return null;
    }

    public void OnXmlLoad()
    {
        TextAsset xml = ResourcesManager.Load<TextAsset>("Configs/Garbages");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(xml.text);

        XmlNodeList list = xmlDoc.SelectSingleNode("root").ChildNodes;
        foreach (XmlElement item in list)
        {
            GarbageVo garbage = new GarbageVo(item);
            garbageDict[garbage.Id] = garbage;
        }
    }

    public event Action<GarbageVo> addGarbage;
    public event Action<GarbageVo> updateNum;
    public void AddGarbage(GarbageVo garbage)
    {
        for(int i = 0; i < bagList.Count; i++)
        {
            if(bagList[i].Id == garbage.Id && bagList[i].Num < bagList[i].MaxCount)
            {
                bagList[i].Num++;
                //通知垃圾自己去刷新垃圾数量
                updateNum(bagList[i]);
                return;
            }
        }
        //背包中没有这个垃圾
        bagList.Add(garbage);
        
        //通知界面去刷新
        addGarbage(garbage);
    }
}
