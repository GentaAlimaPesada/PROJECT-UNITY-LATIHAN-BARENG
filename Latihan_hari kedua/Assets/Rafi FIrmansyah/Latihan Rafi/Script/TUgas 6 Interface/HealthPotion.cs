using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IntrfcRafi;

public class HealthPotion : MonoBehaviour , IPickAble
{
    public float healthToAdd = 20f;


    public void Pickup()
    {
        Health playerHealth = FindObjectOfType<Health>();
        if (playerHealth != null)
        {
            playerHealth.Heal(healthToAdd);
            Destroy(gameObject);
        }
    }
}
