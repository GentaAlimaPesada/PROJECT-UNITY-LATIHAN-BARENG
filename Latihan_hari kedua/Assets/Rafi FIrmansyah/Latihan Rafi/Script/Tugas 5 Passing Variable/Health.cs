using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif 

public class Health : MonoBehaviour
{
    [Header("Health Atribute")]

    public float maxHealth = 100f;
    public float currentHealth;

    [Header ("Panel Object")]

    public GameObject deathPanel;
    [SerializeField] private Image healthBarFill; 

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth,0, maxHealth);
        UpdateHealthBar();

        if (currentHealth == 0)
        {
            deathPanel.SetActive(true);
        }
    }

    public void Heal(float amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Min(currentHealth, maxHealth);
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        healthBarFill.fillAmount = currentHealth / maxHealth ;
    }
}



