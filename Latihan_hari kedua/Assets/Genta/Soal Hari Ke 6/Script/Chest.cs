using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("Chest opened!");
        // Logika untuk interaksi dengan peti harta karun
    }
}

