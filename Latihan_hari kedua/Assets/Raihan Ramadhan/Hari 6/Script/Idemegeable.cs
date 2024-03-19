using UnityEngine;

public class Idemegeable : MonoBehaviour
{
    public int health = 100; // Health of the idemegeable object

    // Method to receive damage
    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount; // Reduce health by damageAmount

        if (health <= 0)
        {
            Die(); // Call the Die method if health is less than or equal to 0
        }
    }

    // Method to handle death
    void Die()
    {
        // Destroy the idemegeable object
        Destroy(gameObject);
    }
}
