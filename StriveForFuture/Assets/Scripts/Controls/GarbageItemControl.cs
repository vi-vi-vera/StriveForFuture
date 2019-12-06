using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageItemControl : MonoBehaviour
{
    GarbageModel model;
    GarbageItemView view;

    GarbageVo garbage;
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetData(GarbageVo garbage)
    {
        model = GarbageModel.Instance;
        view = GetComponent<GarbageItemView>();
        model.updateNum += UpdateNum;//添加事件触发函数

        this.garbage = garbage;
        view.Img_Icon.sprite = ResourcesManager.Load<Sprite>("Garbages/" + garbage.Id);
        view.Txt_Num.text = garbage.Num.ToString();
    }

    void UpdateNum(GarbageVo garbage)
    {
        if(this.garbage == garbage)
        {
            view.Txt_Num.text = garbage.Num.ToString();
        }
    }
}
