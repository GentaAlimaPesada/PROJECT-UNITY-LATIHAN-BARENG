using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public float speed; // Kecepatan pergerakan
    private Rigidbody2D rb;

    public Slider healthSlider; // Slider untuk menampilkan kesehatan pada UI

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();

        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Mendapatkan input dari sumbu horizontal dan vertikal
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Menentukan vektor pergerakan berdasarkan input
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // Normalisasi vektor pergerakan jika pemain bergerak diagonal
        if (movement.magnitude > 1f)
        {
            movement.Normalize();
        }

        // Menggerakkan pemain dengan Rigidbody
        rb.velocity = movement * speed;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Memastikan kesehatan tidak kurang dari 0 dan tidak lebih dari maxHealth
        UpdateHealthUI();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void UpdateHealthUI()
    {
        healthSlider.value = currentHealth;
    }

    private void Die()
    {
        // Lakukan tindakan saat player mati, misalnya mengaktifkan UI Game Over
        Debug.Log("Player mati!");
    }
}
