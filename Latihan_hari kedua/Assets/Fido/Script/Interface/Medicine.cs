using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IntrfcFido;

public class Medicine : MonoBehaviour, IPickAble
{
    public int healthToAdd; // Jumlah kesehatan yang akan ditambahkan saat item diambil

    public void OnPickUp()
    {
        // Menambahkan health pada healthbar player
        HealthbarScript healthbar = FindObjectOfType<HealthbarScript>(); // Mencari objek HealthbarScript di scene
        if (healthbar != null)
        {
            healthbar.AddHealth(healthToAdd);
        }

        // Optional: menonaktifkan objek setelah diambil
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
