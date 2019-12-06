using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIEventListener : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public event Action<PointerEventData> OnEnterHandler;
    public event Action<PointerEventData> OnExitHandler;
    public event Action<PointerEventData> OnDownHandler;
    public event Action<PointerEventData> OnUpHandler;
    public event Action<PointerEventData> OnClickHandler;
    public event Action<PointerEventData> OnBeginDragHandler;
    public event Action<PointerEventData> OnDragHandler;
    public event Action<PointerEventData> OnEndDragHandler;

    private static UIEventListener listener = null;

    public static UIEventListener Get(UIBehaviour UI)
    {
        GameObject go = UI.gameObject;
        listener = go.GetComponent<UIEventListener>();
        if (listener == null)
        {
            listener = go.AddComponent<UIEventListener>();
        }
        return listener;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (OnBeginDragHandler != null)
        {
            OnBeginDragHandler(eventData);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (OnDragHandler != null)
        {
            OnDragHandler(eventData);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (OnEndDragHandler != null)
        {
            OnEndDragHandler(eventData);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (OnClickHandler != null)
        {
            OnClickHandler(eventData);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (OnDownHandler != null)
        {
            OnDownHandler(eventData);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (OnEnterHandler != null)
        {
            OnEnterHandler(eventData);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (OnExitHandler != null)
        {
            OnExitHandler(eventData);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (OnUpHandler != null)
        {
            OnUpHandler(eventData);
        }
    }
}
