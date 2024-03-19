using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Image healthFillImage; // Gambar untuk mengisi kesehatan pada UI

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
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

    public void AddHealth(int addHealth)
    {
        currentHealth += addHealth;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Memastikan kesehatan tidak kurang dari 0 dan tidak lebih dari maxHealth
        UpdateHealthUI();
    }

    private void UpdateHealthUI()
    {
        float fillAmount = (float)currentHealth / maxHealth;
        healthFillImage.fillAmount = fillAmount;
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
