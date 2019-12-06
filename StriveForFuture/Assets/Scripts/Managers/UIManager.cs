using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 代码功能：1. 管理其他界面的打开关闭 2. 保存全局的Canvas属性 3. 向背包中添加道具
/// </summary>
public class UIManager : MonoBehaviour
{
    public RoleInfoView roleInfoView;
    GameObject bagView;
    RectTransform canvas;

    // Start is called before the first frame update
    void Start()
    {
        //游戏开始时默认关闭roleInfoView
        roleInfoView.gameObject.SetActive(false);

        //游戏开始时默认关闭bagView
        bagView = GameObject.Find("BagView");
        bagView.SetActive(false);

        canvas = transform as RectTransform;
    }

    public RectTransform GlobalCanvas { get => canvas; }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            roleInfoView.gameObject.SetActive(!roleInfoView.gameObject.activeSelf);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            bagView.gameObject.SetActive(!bagView.gameObject.activeSelf);
        }
    }
}
