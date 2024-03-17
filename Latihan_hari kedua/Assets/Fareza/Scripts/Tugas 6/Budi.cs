using System;
using UnityEngine;

public class Budi : MonoBehaviour, IClickable
{
    public void OnClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Halo Saya Budi");
        }
    }

    private void Update() {
        OnClick();
    }
}