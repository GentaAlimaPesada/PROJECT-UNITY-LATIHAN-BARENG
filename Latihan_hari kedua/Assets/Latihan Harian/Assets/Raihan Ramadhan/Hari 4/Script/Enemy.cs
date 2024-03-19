using UnityEngine;

public class Enemyis : MonoBehaviour, IDamageable
{
    public void TakeDamage(int amount)
    {
        Debug.Log("Enemy takes " + amount + " damage.");
    }
}