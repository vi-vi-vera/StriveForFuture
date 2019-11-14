using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoleInfoView : MonoBehaviour
{
    Text txt_Title;

    public Text Txt_Title
    {
        get
        {
            if(txt_Title == null)
            {
                txt_Title = transform.Find("Txt_Title").GetComponent<Text>();
            }
            return txt_Title;
        }
    }

    Button btn_Close;

    public Button Btn_Close
    {
        get
        {
            if(btn_Close == null)
            {
                btn_Close = transform.Find("Btn_Close").GetComponent<Button>();
            }
            return btn_Close;
        }
    }

    Image img_Body;

    public Image Img_Body
    {
        get
        {
            if(img_Body == null)
            {
                img_Body = transform.Find("Img_Body").GetComponent<Image>();
            }
            return img_Body;
        }
    }

    Transform attributeGroup;

    public Transform AttributeGroup
    {
        get
        {
            if(attributeGroup == null)
            {
                attributeGroup = transform.Find("AttributeGroup").GetComponent<Transform>();
            }
            return attributeGroup;
        }
    }

    Text txt_Name;

    public Text Txt_Name
    {
        get
        {
            if(txt_Name == null)
            {
                txt_Name = AttributeGroup.transform.Find("Txt_Name").GetComponent<Text>();
            }
            return txt_Name;
        }
    }

    Text txt_Money;

    public Text Txt_Money
    {
        get
        {
            if(txt_Money == null)
            {
                txt_Money = AttributeGroup.transform.Find("Txt_Money").GetComponent<Text>();
            }
            return txt_Money;
        }
    }

    Text txt_Level;

    public Text Txt_Level
    {
        get
        {
            if(txt_Level == null)
            {
                txt_Level = AttributeGroup.transform.Find("Txt_Level").GetComponent<Text>();
            }
            return txt_Level;
        }
    }

    Text txt_Exp;

    public Text Txt_Exp
    {
        get
        {
            if(txt_Exp == null)
            {
                txt_Exp = AttributeGroup.transform.Find("Txt_Exp").GetComponent<Text>();
            }
            return txt_Exp;
        }
    }

    Transform dotGroup;

    public Transform DotGroup
    {
        get
        {
            if(dotGroup == null)
            {
                dotGroup = transform.Find("DotGroup").GetComponent<Transform>();
            }
            return dotGroup;
        }
    }

    Text txt_Strength;

    public Text Txt_Strength
    {
        get
        {
            if(txt_Strength == null)
            {
                txt_Strength = DotGroup.transform.Find("Txt_Strength").GetComponent<Text>();
            }
            return txt_Strength;
        }
    }

    Button btn_AddStrength;

    public Button Btn_AddStrength
    {
        get
        {
            if(btn_AddStrength == null)
            {
                btn_AddStrength = Txt_Strength.transform.Find("Btn_AddStrength").GetComponent<Button>();
            }
            return btn_AddStrength;
        }
    }

    Text txt_Agility;

    public Text Txt_Agility
    {
        get
        {
            if(txt_Agility == null)
            {
                txt_Agility = DotGroup.transform.Find("Txt_Agility").GetComponent<Text>();
            }
            return txt_Agility;
        }
    }

    Button btn_AddAgility;

    public Button Btn_AddAgility
    {
        get
        {
            if(btn_AddAgility == null)
            {
                btn_AddAgility = Txt_Agility.transform.Find("Btn_AddAgility").GetComponent<Button>();
            }
            return btn_AddAgility;
        }
    }

    Text txt_LeftDots;

    public Text Txt_LeftDots
    {
        get
        {
            if(txt_LeftDots == null)
            {
                txt_LeftDots = DotGroup.transform.Find("Txt_LeftDots").GetComponent<Text>();
            }
            return txt_LeftDots;
        }
    }

}
