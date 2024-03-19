using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 20; // Nilai koin

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Mendapatkan komponen PlayerController dari pemain
            PlayerController playerController = collision.GetComponent<PlayerController>();
            if (playerController != null)
            {
                // Menambahkan nilai koin ke pemain
                playerController.AddCoin(coinValue);
                // Menghapus koin setelah diambil
                Destroy(gameObject);
            }
        }
    }
}
