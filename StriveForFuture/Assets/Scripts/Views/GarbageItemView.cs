using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GarbageItemView : MonoBehaviour
{
    Text txt_Num;

    public Text Txt_Num
    {
        get
        {
            if(txt_Num == null)
            {
                txt_Num = transform.Find("Txt_Num").GetComponent<Text>();
            }
            return txt_Num;
        }
    }

    Image img_Icon;
    public Image Img_Icon
    {
        get
        {
            if(img_Icon == null)
            {
                img_Icon = GetComponent<Image>();
            }
            return img_Icon;
        }
    }

    Button btn_Choose;
    public Button Btn_Choose
    {
        get
        {
            if(btn_Choose == null)
            {
                btn_Choose = transform.Find("Btn_Choose").GetComponent<Button>();
            }
            return btn_Choose;
        }
    }
}
