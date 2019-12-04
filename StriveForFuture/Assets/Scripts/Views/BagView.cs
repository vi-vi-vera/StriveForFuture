using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagView : MonoBehaviour
{
    Transform viewport;

    public Transform Viewport
    {
        get
        {
            if(viewport == null)
            {
                viewport = transform.Find("Viewport").GetComponent<Transform>();
            }
            return viewport;
        }
    }

    Transform content;

    public Transform Content
    {
        get
        {
            if(content == null)
            {
                content = Viewport.transform.Find("Content").GetComponent<Transform>();
            }
            return content;
        }
    }

    RectTransform[] grids;

    public RectTransform[] Grids
    {
        get
        {
            if(grids == null)
            {
                grids = new RectTransform[Content.childCount];
            }
            for(int i = 0; i < grids.Length; i++)
            {
                grids[i] = Content.GetChild(i) as RectTransform;
            }
            return grids;
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

}
