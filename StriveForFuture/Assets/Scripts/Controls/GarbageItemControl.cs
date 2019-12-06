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
        view.Txt_Num.text = garbage.Num.ToString();
    }

    public void SetData(GarbageVo garbage)
    {
        model = GarbageModel.Instance;
        view = GetComponent<GarbageItemView>();
        //model.updataNum += UpdateNum;

        this.garbage = garbage;
        view.Img_Icon.sprite = ResourcesManager.Load<Sprite>("Garbages/" + garbage.Id);
        view.Txt_Num.text = garbage.Num.ToString();
    }
}
