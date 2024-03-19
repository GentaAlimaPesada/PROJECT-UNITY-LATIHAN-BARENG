using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPotion : MonoBehaviour, IPickAble
{
    public float speedAdd; // Jumlah jump force yang akan ditambahkan saat item diambil
    
    public void OnPickUp()
    {
        PlayerScript playerJump = FindObjectOfType<PlayerScript>(); // Mencari objek HealthbarScript di scene  
        playerJump.moveSpeed += speedAdd;

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
