using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVo//Value object
{
    string name;        //姓名
    int money;          //钱
    int level;          //等级
    int exp;            //经验值
    int maxExp;         //最大经验值
    int strength;       //力量
    int agility;        //敏捷
    int maxAgility;     //最大敏捷
    int leftDots;       //剩余点数


    public string Name { get => name; }
    public int Money { get => money; }
    public int Level { get => level; }
    public int Exp { get => exp; }
    public int MaxExp { get => maxExp; }
    public int Strength { get => strength; }
    public int Agility { get => agility; }
    public int MaxAgility { get => maxAgility; }
    public int LeftDots { get => leftDots; }

    public PlayerVo()
    {
        name = "小张";
        money = 0;
        level = 1;
        exp = 0;
        maxExp = 100;
        strength = 15;
        agility = 20;
        maxAgility = 40;
        leftDots = 0;
    }
    
    public void LevelUp()
    {
        level++;
        leftDots += 2;
        maxExp *= 2;
        exp = 0;
    }

    public void AddStrength()
    {
        strength++;
        leftDots--;
    }

    public void AddAgility()
    {
        agility++;
        leftDots--;
    }
}
