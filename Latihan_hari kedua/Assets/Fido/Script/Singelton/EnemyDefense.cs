using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDefense : MonoBehaviour
{
    public Transform target; // Assuming this is the target you want to attack

    private void Update()
    {
        Attack();
    }

    public void Attack()
    {
        if (target != null)
        {
            float distance = Vector3.Distance(transform.position, target.position);
            float damage = DamageManager.Instance.CalculateDamage(distance);
            // Apply damage to the target or do other actions based on the calculated damage
            Debug.Log("Dealt damage: " + damage);
        }
        else
        {
            Debug.LogWarning("No target assigned to attack!");
        }
    }
}
