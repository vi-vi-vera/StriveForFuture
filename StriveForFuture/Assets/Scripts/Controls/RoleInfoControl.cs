using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleInfoControl : MonoBehaviour
{
    RoleInfoView view;
    PlayerVo player;

    // Start is called before the first frame update
    void Awake()
    {
        player = PlayerModel.Instance.Player;
        view = GetComponent<RoleInfoView>();

        view.Btn_Close.onClick.AddListener(() => gameObject.SetActive(false));
        view.Btn_AddStrength.onClick.AddListener(AddStrength);
        view.Btn_AddAgility.onClick.AddListener(AddAgility);
        GarbageCanController.updatePlayerInfo += UpdateAttribute;
        UpdateAttribute();
    }

    void UpdateAttribute()
    {
        view.Txt_Name.text = "姓名：" + player.Name;
        view.Txt_Money.text = "余额：" + player.Money;
        view.Txt_Level.text = "等级：" + player.Level;
        view.Txt_Exp.text = "经验：" + player.Exp + "/" + player.MaxExp;
        view.Txt_Strength.text = "力量：" + player.Strength;
        view.Txt_Agility.text = "敏捷：" + player.Agility + "/" + player.MaxAgility;
        view.Txt_LeftDots.text = "剩余点数：" + player.LeftDots;
    }

    private void AddStrength()
    {
        player.AddStrength();
        UpdateAttribute();
    }

    private void AddAgility()
    {
        if(player.Agility < player.MaxAgility)
        {
            player.AddAgility();
            UpdateAttribute();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    player.LevelUp();
        //    UpdateAttribute();
        //}

        //剩余点数 <=0 禁用两个按钮
        view.Btn_AddStrength.interactable = player.LeftDots > 0;
        if(player.LeftDots <= 0 || player.Agility >= player.MaxAgility)
        {
            view.Btn_AddAgility.interactable = false;
        }
        else
        {
            view.Btn_AddAgility.interactable = true;
        }
    }
}
