﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextLogItem : MonoBehaviour
{
    
    public void SetText(string text, Color color)
    {
        GetComponent<Text>().text = text;
        GetComponent<Text>().color = color;
    }
}
