using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CustomUnityEvent : UnityEvent<GameObject, CustomEventArgs>
{

}

public class CustomEventArgs
{
    public CustomEventArgs()
    {

    }

    public CustomEventArgs(PointerEventData data)
    {

    }


}
