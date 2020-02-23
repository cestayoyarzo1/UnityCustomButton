using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//File Created by Carlos Estay
//carlos.estay@gmail.com
//https://github.com/cestayoyarzo1
//February 22nd, 2020
//This script creates a custom button class that exposes extra handlers for buttons using Unity Events

public class CustomButton : Button
{

    public override void OnPointerEnter(PointerEventData eventData)
    {
        base.OnPointerEnter(eventData);
        EventManager.Instance.onPointerEnter.Invoke(gameObject, new CustomEventArgs(eventData));
    }

    public override void OnPointerExit(PointerEventData eventData)
    {
        base.OnPointerExit(eventData);
        EventManager.Instance.onPointerExit.Invoke(gameObject, new CustomEventArgs(eventData));
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        EventManager.Instance.onPointerDown.Invoke(gameObject, new CustomEventArgs(eventData));
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        EventManager.Instance.onPointerUp.Invoke(gameObject, new CustomEventArgs(eventData));
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
        EventManager.Instance.onPointerClick.Invoke(gameObject, new CustomEventArgs(eventData));
    }

}
