using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    // Singleton instance
    private static DamageManager _instance;
    public static DamageManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<DamageManager>();
                if (_instance == null)
                {
                    GameObject singleton = new GameObject("DamageManager");
                    _instance = singleton.AddComponent<DamageManager>();
                }
            }
            return _instance;
        }
    }

    // Damage formula based on range
    public float CalculateDamage(float range)
    {
        // Example formula, replace this with your own formula
        float damage = 0f;
        if (range < 5f)
        {
            damage = 20f;
        }
        else if (range >= 5f && range < 10f)
        {
            damage = 15f;
        }
        else
        {
            damage = 10f;
        }
        return damage;
    }
}
