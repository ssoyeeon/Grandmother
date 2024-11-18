using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string Name;     // ¹¹°¡ ³ª¿ÔÀ»±î¿ä

    public void Yut()
    {
        int RandonNum = Random.Range(0, 16);
        if (RandonNum < 5) Name = "µµ"; 
        else if (RandonNum < 10) Name = "°³";
        else if (RandonNum < 14) Name = "°É";
        else if (RandonNum == 14) Name = "À·";
        else Name = "¸ð";
        Debug.Log("À· °á°ú: " + Name);
    }
}
