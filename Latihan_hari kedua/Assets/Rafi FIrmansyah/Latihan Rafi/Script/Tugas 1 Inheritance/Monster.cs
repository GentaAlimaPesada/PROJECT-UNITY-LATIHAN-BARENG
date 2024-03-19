using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AtributeMonster;

public class Monster : MonoBehaviour
{
    public string Name;

    [Range(0, 2000)]
    public int health ;

    [Range (0, 500)]
    public int attack ;

    [Header("Karakteristik Monster")] 
    public TypeMonster typeMonster;
    public Element element;

    public void InfoMonster()
    {
        Debug.Log("Nama Monster : " + Name + " " + "Type Monster : " + typeMonster + " " + " Element : " + element + " " + "Attack : " + attack + " "+ "Health : "+ health);
    }
}
