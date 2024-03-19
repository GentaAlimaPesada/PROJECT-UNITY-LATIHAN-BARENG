using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPassingVariable : MonoBehaviour
{
    public int damage = 10; // Kerusakan yang akan diberikan kepada player saat bersentuhan dengan musuh

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }
        }
    }
}
