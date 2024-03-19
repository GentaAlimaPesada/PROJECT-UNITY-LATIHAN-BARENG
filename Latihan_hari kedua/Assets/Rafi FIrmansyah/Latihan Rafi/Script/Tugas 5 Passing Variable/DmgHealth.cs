using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgHealth : MonoBehaviour
{
    public float reduceHealth = 20f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            Health playerHealth = other.collider.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(reduceHealth);
            }
        }
    }


}
