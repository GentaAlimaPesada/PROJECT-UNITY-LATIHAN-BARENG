using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicPotion : MonoBehaviour , IPickAble
{
    public float reduceHealth = 20f;

    public void Pickup()
    {
        Health playerHealth = FindObjectOfType<Health>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(reduceHealth);
            Destroy(gameObject);
        }
    }
}
