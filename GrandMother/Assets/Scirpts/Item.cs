using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string Name;     // ���� ���������

    public void Yut()
    {
        int RandonNum = Random.Range(0, 16);
        if (RandonNum < 5) Name = "��"; 
        else if (RandonNum < 10) Name = "��";
        else if (RandonNum < 14) Name = "��";
        else if (RandonNum == 14) Name = "��";
        else Name = "��";
        Debug.Log("�� ���: " + Name);
    }
}
