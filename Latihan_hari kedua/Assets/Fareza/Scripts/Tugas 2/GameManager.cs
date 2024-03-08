using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set;}
    public static Action<int> OnPlayerApproachingDoor;

    private void Awake() {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    
    public void PlayerApproachingDoor(int doorID)
    {
        OnPlayerApproachingDoor?.Invoke(doorID);
    }
}
