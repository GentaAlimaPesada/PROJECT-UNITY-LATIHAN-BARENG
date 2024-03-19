using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int healthPoints;
    private bool isAlive = true;

    public virtual void TakeDamage(int damage)
    {
        if (!isAlive) // Memeriksa apakah karakter masih hidup sebelum menerima kerusakan
            return;

        healthPoints -= damage;
        Debug.Log("Health Point " + healthPoints);

        if (healthPoints == 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        isAlive = false; // Menetapkan karakter sebagai mati
        Debug.Log("Character has died.");
    }
}
