using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TestButton : MonoBehaviour
{
    CustomButton testButton;

    Color currentColor, hoverColor;

    void Start()
    {
        testButton = GetComponentInChildren<CustomButton>();
        testButton.onPointerClick.AddListener(ButtonClicked);
        testButton.onPointerEnter.AddListener(PointerEnter);
        testButton.onPointerExit.AddListener(PointerExit);
        testButton.onPointerUp.AddListener(PointerUp);
        testButton.onPointerDown.AddListener(PointerDown);
        hoverColor = Color.blue;
        currentColor = testButton.image.color;
    }

    private void PointerUp()
    {
        print("Pointer is Up");
    }

    private void PointerDown()
    {
        print("Pointer is Down");
    }

    private void PointerExit()
    {
        print("Pointer has exited");
        testButton.image.color = currentColor;
    }

    private void PointerEnter()
    {
        print("Pointer has entered");
        testButton.image.color = hoverColor;
    }

    private void ButtonClicked()
    {
        print("Button has been clicked");
    }

    void Update()
    {
        
    }
}
