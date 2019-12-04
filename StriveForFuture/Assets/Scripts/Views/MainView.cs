using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainView : MonoBehaviour
{
    Button btn_BagView;

    public Button Btn_BagView
    {
        get
        {
            if(btn_BagView == null)
            {
                btn_BagView = transform.Find("Btn_BagView").GetComponent<Button>();
            }
            return btn_BagView;
        }
    }

    Button btn_RoleInfoView;

    public Button Btn_RoleInfoView
    {
        get
        {
            if(btn_RoleInfoView == null)
            {
                btn_RoleInfoView = transform.Find("Btn_RoleInfoView").GetComponent<Button>();
            }
            return btn_RoleInfoView;
        }
    }

}
