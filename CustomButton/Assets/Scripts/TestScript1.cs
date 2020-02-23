using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//File Created by Carlos Estay
//carlos.estay@gmail.com
//https://github.com/cestayoyarzo1
//Defruary 22nd, 2020
//This script is just for testing

public class TestScript1 : MonoBehaviour
{

    Color tempColor, hoverColor;
    [SerializeField]
    CustomButton[] buttons;
    CustomButton clickedButton;
    [SerializeField]
    Panel[] panels;
    GameObject activePanel, clickedPanel;

    
    void Start()
    {
        hoverColor = new Color(0, 1, 1);
        buttons = GetComponentsInChildren<CustomButton>();
        panels = GetComponentsInChildren<Panel>();

        EventManager.Instance.onPointerClick.AddListener(ButtonClicked);
        EventManager.Instance.onPointerEnter.AddListener(PointerEnter);
        EventManager.Instance.onPointerExit.AddListener(PointerExit);
        EventManager.Instance.onPointerUp.AddListener(PointerUp);
        EventManager.Instance.onPointerDown.AddListener(PointerDown);
        //EventManager.Instance.Beacon();

        foreach (CustomButton item in buttons)
        {
            item.GetComponentInChildren<Outline>().enabled = false;
        }

        foreach (Panel item in panels)
        {
            item.gameObject.SetActive(false);
        }
        activePanel = panels[0].gameObject;
        clickedPanel = panels[0].gameObject;
        clickedButton = buttons[0];
        tempColor = buttons[0].image.color;
        activePanel.SetActive(true);
        clickedButton.GetComponentInChildren<Outline>().enabled = true;
    }

    private void OnDisable()
    {//Only try to unsubscribe if Event Manager has not yet been destroyed
#pragma warning disable UNT0008 // Null propagation on Unity objects
        EventManager.Instance?.onPointerClick.RemoveListener(ButtonClicked);
        EventManager.Instance?.onPointerEnter.RemoveListener(PointerEnter);
        EventManager.Instance?.onPointerExit.RemoveListener(PointerExit);
        EventManager.Instance?.onPointerUp.RemoveListener(PointerUp);
        EventManager.Instance?.onPointerDown.RemoveListener(PointerDown);
#pragma warning restore UNT0008 // Null propagation on Unity objects
    }

    private void PointerDown(GameObject arg0, CustomEventArgs arg1)
    {
        print("Pointer is Down");
    }

    private void PointerUp(GameObject arg0, CustomEventArgs arg1)
    {
        print("Pointer is Up");
    }

    private void PointerExit(GameObject buttonObject, CustomEventArgs arg1)
    {
        CustomButton foundButton = buttonObject.GetComponentInChildren<CustomButton>();
        foundButton.image.color = tempColor;
        int foundIndex = Array.FindIndex(buttons, x => x.Equals(foundButton));
        activePanel.SetActive(false);
        activePanel = clickedPanel;
        activePanel.SetActive(true);

    }

    private void PointerEnter(GameObject buttonObject, CustomEventArgs arg1)
    {
        CustomButton foundButton = buttonObject.GetComponentInChildren<CustomButton>();
        foundButton.image.color = hoverColor;
        int foundIndex = Array.FindIndex(buttons, x => x.Equals(foundButton));
        if (!activePanel.Equals(panels[foundIndex]))
        {
            activePanel.SetActive(false);
            activePanel = panels[foundIndex].gameObject;
            activePanel.SetActive(true);
        }
    }

    private void ButtonClicked(GameObject buttonObject, CustomEventArgs arg1)
    {
        CustomButton foundButton = buttonObject.GetComponentInChildren<CustomButton>();
        int foundIndex = Array.FindIndex(buttons, x => x.Equals(foundButton));
        if (!clickedPanel.Equals(panels[foundIndex]))
        {
            clickedPanel = panels[foundIndex].gameObject;
            clickedButton.GetComponentInChildren<Outline>().enabled = false;
            clickedButton = buttons[foundIndex];
            clickedButton.GetComponentInChildren<Outline>().enabled = true;
        }
    }

    private void PointerUp()
    {
        print("Pointer is Up");
    }

    private void PointerDown()
    {
        print("Pointer is Down");
    }
}
