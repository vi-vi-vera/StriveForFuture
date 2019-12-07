using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCanController : MonoBehaviour
{
    string type;
    float range;
    PlayerController pc;
    public static event Action throwGarbage;
    public static event Action updatePlayerInfo;
    // Start is called before the first frame update
    void Start()
    {
        type = transform.name;
        range = 0.6f;
    }

    // Update is called once per frame
    void Update()
    {
        //游戏主角可能在游戏过程中因没钱而死
        pc = GameObject.Find("Player").GetComponent<PlayerController>();
        if (pc != null)
        {
            if (VectorUtil.Distance(transform.position, pc.transform.position) <= range)
            {
                //Debug.Log("Near" + type);
                if (Input.GetKeyDown(KeyCode.J))
                {
                    if (pc.ChoosenGarbage == null)
                    {
                        Debug.Log("您需要先在背包中选择一个垃圾");
                        return;
                    }
                    if (type.Equals(pc.ChoosenGarbage.Type))
                    {
                        //丢垃圾到正确的垃圾桶了，奖赏
                        //Debug.Log("丢垃圾" + pc.ChoosenGarbage.Name + "到正确的垃圾桶了");
                        PlayerModel.Instance.Player.ReWard();
                    }
                    else
                    {
                        //丢错了垃圾桶，罚款
                        //Debug.Log("丢垃圾" + pc.ChoosenGarbage.Name + "到错误的垃圾桶了");
                        PlayerModel.Instance.Player.ImposeFine();
                    }
                    //通知界面刷新
                    updatePlayerInfo();
                    //垃圾丢弃后通知从背包中删除该垃圾，并刷新界面
                    throwGarbage();
                }
            }
        }
        
    }

    
}
