using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//File Created by Carlos Estay
//carlos.estay@gmail.com
//https://github.com/cestayoyarzo1
//February 22nd, 2020
//This script contains the event manager based on a non persistent singleton patern

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
        //change this line for making the object persistent
        _SingletonType = SingletonType.NonPersitent;
    }

    private void Awake()
    {
        onPointerEnter = new CustomUnityEvent();
        onPointerExit = new CustomUnityEvent();
        onPointerDown = new CustomUnityEvent();
        onPointerUp = new CustomUnityEvent();
        onPointerClick = new CustomUnityEvent();
        Beacon();//Print a message on the consolo to show the EventManager has been created
    }

    public  void Beacon()
    {
        print("Hello World from Event Manager");
    }

    public override void ChildDestroy()
    {      
        base.ChildDestroy();
        //Remove all listeners before destroying the object
        print("Event Manager is about to be destroyed");
        onPointerEnter.RemoveAllListeners();
        onPointerExit.RemoveAllListeners();
        onPointerUp.RemoveAllListeners();
        onPointerDown.RemoveAllListeners();
        onPointerClick.RemoveAllListeners();
    }

}
