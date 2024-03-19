using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjekHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Implementasi apa yang terjadi ketika pemain mati
        Debug.Log("Player has died!");
        // Misalnya: respawn pemain, tampilkan layar kalah, dll.
    }

    private void Update()
    {
        Debug.Log(currentHealth);
    }
}
