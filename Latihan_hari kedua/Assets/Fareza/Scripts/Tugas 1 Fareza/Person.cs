using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    [Header("Statistik Manusia")]
    [SerializeField] private string nama;
    
    [Range(0, 60)]
    [SerializeField] private int umur;
    public void Age()
    {
        if(name != null)
            Debug.Log("Atas Nama : " + nama + " Sudah berumur " + umur);
        else
            Debug.LogWarning("Nama Belom diisi");
    }
}
