using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicPotion : MonoBehaviour, IPickAble
{
    public int potionAmount; // Jumlah jump force yang akan ditambahkan saat item diambil

    public void OnPickUp()
    {
        HealthbarScript playerHealth = FindObjectOfType<HealthbarScript>(); // Mencari objek HealthbarScript di scene  
        playerHealth.TakeDamage(potionAmount);

        gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnPickUp();
        }
    }
}
