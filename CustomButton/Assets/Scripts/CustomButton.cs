using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CustomButton : Button
{

    public UnityEvent onPointerEnter { get; set; }
    public UnityEvent onPointerExit { get; set; }
    public UnityEvent onPointerDown { get; set; }
    public UnityEvent onPointerUp { get; set; }
    public UnityEvent onPointerClick { get; set; }

    protected override void Awake()
    {
        onPointerEnter = new UnityEvent();
        onPointerExit = new UnityEvent();
        onPointerDown = new UnityEvent();
        onPointerUp = new UnityEvent();
        onPointerClick = new UnityEvent();
    }

    public override void OnPointerEnter(PointerEventData eventData)
    {
        base.OnPointerEnter(eventData);
        onPointerEnter.Invoke();
    }

    public override void OnPointerExit(PointerEventData eventData)
    {
        base.OnPointerExit(eventData);
        onPointerExit.Invoke();
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        onPointerDown.Invoke();
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        onPointerUp.Invoke();
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
        onPointerClick.Invoke();
    }

}
