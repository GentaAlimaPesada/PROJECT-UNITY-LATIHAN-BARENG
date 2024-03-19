using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("NPC interaction!");
        // Logika untuk interaksi dengan NPC
    }
}

