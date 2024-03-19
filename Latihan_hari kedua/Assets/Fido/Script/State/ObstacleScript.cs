using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public int damagePoint;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HealthbarScript healthPlayer = collision.gameObject.GetComponent<HealthbarScript>();
            if (healthPlayer != null)
            {
                healthPlayer.TakeDamage(damagePoint);
            }
        }
    }
}
