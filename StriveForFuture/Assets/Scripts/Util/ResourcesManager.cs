using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ResourcesManager
{
    static Dictionary<string, GameObject> resDict = new Dictionary<string, GameObject>();

    public static GameObject Load(string path)
    {
        if (resDict.ContainsKey(path))
        {
            return resDict[path];
        }
        GameObject prefab = Resources.Load(path) as GameObject;
        resDict[path] = prefab;
        return prefab;
    }

    static Hashtable resTable = new Hashtable();

    public static T Load<T>(string path) where T : UnityEngine.Object
    {
        if (resTable.ContainsKey(path))
        {
            return resTable[path] as T;
        }
        T t = Resources.Load<T>(path);
        resTable[path] = t;
        return t;
    }
}
