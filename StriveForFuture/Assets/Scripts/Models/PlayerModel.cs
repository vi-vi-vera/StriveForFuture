using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    //单例模式
    private static PlayerModel _instance = null;

    private PlayerModel()
    {

    }

    public static PlayerModel Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new PlayerModel();
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
