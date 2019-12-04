using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public RoleInfoView roleInfoView;
    public BagView bagView;
    // Start is called before the first frame update
    void Start()
    {
        //游戏开始时默认关闭roleInfoView
        roleInfoView.gameObject.SetActive(false);

        //游戏开始时默认关闭bagView
        bagView.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
