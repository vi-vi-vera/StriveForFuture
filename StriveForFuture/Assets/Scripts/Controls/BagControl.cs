using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagControl : MonoBehaviour
{
    BagView view;
    GarbageModel model;
    void Awake()
    {
        view = GetComponent<BagView>();
        model = GarbageModel.Instance;

        view.Btn_Close.onClick.AddListener(() => gameObject.SetActive(false));
        model.addGarbage += AddGarbage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddGarbage(GarbageVo garbage)
    {
        //实例化一个垃圾的预制物出来
        GameObject prefabs = ResourcesManager.Load("Prefabs/GarbageItemView");
        GameObject garbageItem = Instantiate(prefabs) as GameObject;
        //将垃圾放置到第一个空格子处，位置归0
        RectTransform firstEmptyGrid = GetFirstEmptyGrid();
        if (firstEmptyGrid != null)
        {
            garbageItem.transform.SetParent(firstEmptyGrid);
            garbageItem.transform.localPosition = Vector2.zero;
            garbageItem.transform.localScale = Vector2.one;
            //给当前垃圾进行赋值操作
            GarbageItemControl scripts = garbageItem.GetComponent<GarbageItemControl>();
            scripts.SetData(garbage);
        }
    }

    //找到第一个空格子处
    RectTransform GetFirstEmptyGrid()
    {
        for(int i = 0; i < view.Grids.Length; i++)
        {
            if(view.Grids[i].childCount <= 0)
            {
                return view.Grids[i];
            }
        }
        return null;
    }
}
