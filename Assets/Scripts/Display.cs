﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    
    public Text PearlsText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PearlsText.text = "Pearls: " + Storage.Pearls.ToString() + " / " + Storage.MaxPearls.ToString();
        if(Storage.Pearls == Storage.MaxPearls){
            PearlsText.text += "\n All pearls are collected";
		}
    }
}
