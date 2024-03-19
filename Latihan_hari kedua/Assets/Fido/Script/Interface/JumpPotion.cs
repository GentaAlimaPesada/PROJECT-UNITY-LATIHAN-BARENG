using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IntrfcFido;

public class JumpPotion : MonoBehaviour, IPickAble
{
    public float jumpForceToAdd; // Jumlah jump force yang akan ditambahkan saat item diambil

    public void OnPickUp()
    {
        PlayerScript playerJump = FindObjectOfType<PlayerScript>(); // Mencari objek HealthbarScript di scene  
        playerJump.jumpForce += jumpForceToAdd;

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
