using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : Singleton<EventManager>
{
    //Unity Events
    public CustomUnityEvent onPointerEnter { get; set; }
    public CustomUnityEvent onPointerExit { get; set; }
    public CustomUnityEvent onPointerDown { get; set; }
    public CustomUnityEvent onPointerUp { get; set; }
    public CustomUnityEvent onPointerClick { get; set; }


    //Constructor
    public EventManager()
    {
        _SingletonType = SingletonType.NonPersitent;
    }

    private void Awake()
    {
        onPointerEnter = new CustomUnityEvent();
        onPointerExit = new CustomUnityEvent();
        onPointerDown = new CustomUnityEvent();
        onPointerUp = new CustomUnityEvent();
        onPointerClick = new CustomUnityEvent();
    }

    public  void Beacon()
    {
        print("Hello World from Event Manager");
    }

}
