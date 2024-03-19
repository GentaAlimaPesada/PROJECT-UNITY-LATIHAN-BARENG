using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int  Health = 100; 
    private int currentHealth;

    void Start()
    {
        currentHealth = Health;
    }

    void Update()
    {
        // Memeriksa jika darah enemy mencapai nol, Maka Object Enemy akan hancur 
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Enemy mati");
        }
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            TakeDamage(20); // Kurangi darah enemy sebanyak 20
            Debug.Log("Hit");

        }
    }

    // Fungsi untuk mengurangi darah enemy
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
