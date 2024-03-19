using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHealth : MonoBehaviour
{
    public float healthToAdd = 20f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            Health playerHealth = other.collider.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.Heal(healthToAdd);
                Destroy(gameObject);
            }
        }
    }
}
