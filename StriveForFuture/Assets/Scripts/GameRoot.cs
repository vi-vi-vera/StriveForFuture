using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 1. 相当于游戏入口 2.加载所有的资源和数据 3.跳转场景不被销毁
/// </summary>
public class GameRoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        //加载数据
        GarbageModel.Instance.OnXmlLoad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
