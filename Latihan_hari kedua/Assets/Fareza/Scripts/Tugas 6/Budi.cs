using System;
using UnityEngine;

public class Budi : MonoBehaviour, IClickable
{
    public void OnClick()
    {
        Debug.Log("Halo Saya Budi");
    }

    private void Update() 
    {
        if(Input.GetMouseButtonDown(0))
        {
           OnClick();
        }
    }
}