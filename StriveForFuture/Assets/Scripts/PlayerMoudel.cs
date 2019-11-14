using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoudel
{
    //单例模式
    private static PlayerMoudel _instance = null;

    private PlayerMoudel()
    {

    }

    public static PlayerMoudel Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new PlayerMoudel();
            }
            return _instance;
        }
    }
    //把一个人物的所有属性列举出来
    PlayerVo player = new PlayerVo();

    public PlayerVo Player
    {
        get
        {
            return player;
        }
    }
}
