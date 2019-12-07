using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GarbageItemControl : MonoBehaviour
{
    GarbageModel model;
    GarbageItemView view;
    PlayerController pc;

    GarbageVo garbage;

    Transform sourceParent;
    Vector3 offset;
    bool isDrag;

    Vector3 Vec2toVec3(Vector2 vector2)
    {
        return new Vector3(vector2.x, vector2.y);
    }
    // Start is called before the first frame update
    void Awake()
    {
        isDrag = false;
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
        
        view.Btn_Choose.gameObject.SetActive(false);

        UIEventListener.Get(view.Img_Icon).OnClickHandler += OnChooseGarge;
        UIEventListener.Get(view.Img_Icon).OnBeginDragHandler += OnBeginDrag;
        UIEventListener.Get(view.Img_Icon).OnDragHandler += OnDrag;
        UIEventListener.Get(view.Img_Icon).OnEndDragHandler += OnEndDrag;

        this.garbage = garbage;
        view.Img_Icon.sprite = ResourcesManager.Load<Sprite>("Garbages/" + garbage.Id);
        view.Txt_Num.text = garbage.Num.ToString();
    }

    private void OnEndDrag(PointerEventData obj)
    {
        isDrag = false;
        throw new NotImplementedException();
    }

    private void OnDrag(PointerEventData obj)
    {
        Vector2 localPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(UIManager.GlobalCanvas, Input.mousePosition, null, out localPos);

        transform.localPosition = Vec2toVec3(localPos) + offset;
    }

    private void OnBeginDrag(PointerEventData obj)
    {
        isDrag = true;
        //1.保存原始的父物体
        sourceParent = transform.parent;
        //2.将父物体设置为Canvas（避免被其他UI遮挡）
        transform.SetParent(UIManager.GlobalCanvas);
        //3.得到偏移量
        Vector2 localPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(UIManager.GlobalCanvas, Input.mousePosition, null, out localPos);
        offset = transform.localPosition - Vec2toVec3(localPos);
    }

    //选择垃圾，弹出按钮选择
    private void OnChooseGarge(PointerEventData obj)
    {
        if (isDrag) return;
        view.Btn_Choose.gameObject.SetActive(true);
        view.Btn_Choose.onClick.AddListener(() => SetPlayerChosenGarbage());
    }

    //设置玩家选择的垃圾
    void SetPlayerChosenGarbage()
    {
        pc = GameObject.Find("Player").GetComponent<PlayerController>();
        if (pc != null)
        {
            pc.ChoosenGarbage = garbage;
            view.Btn_Choose.gameObject.SetActive(false);
            GarbageCanController.throwGarbage -= OnThrowGarbage;
            GarbageCanController.throwGarbage += OnThrowGarbage;
        }
    }

    private void OnThrowGarbage()
    {
        if (pc.ChoosenGarbage != this.garbage || this.garbage == null) return;
        this.garbage.Num--;
        if (this.garbage.Num <= 0)
        {
            GarbageModel.Instance.RemoveGarbage(this.garbage);
            pc.ChoosenGarbage = null;
            Destroy(this.gameObject);
        }
        else
        {
            UpdateNum(this.garbage);
        }
    }

    void UpdateNum(GarbageVo garbage)
    {
        if(this.garbage == garbage)
        {
            view.Txt_Num.text = garbage.Num.ToString();
        }
    }
}
