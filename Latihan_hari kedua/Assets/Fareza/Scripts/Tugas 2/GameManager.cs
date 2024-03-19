using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager Instance { get; private set;}
    private void Awake() 
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    #endregion

    #region Observer
    public static Action<int> OnPlayerApproachingDoor;
    public void PlayerApproachingDoor(int doorID)
    {
        OnPlayerApproachingDoor?.Invoke(doorID);
    }
    #endregion
}
