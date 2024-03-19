using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{

    [SerializeField] private int health = 500;
    public GameObject gameOver;
    public TextMeshProUGUI healthPoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //updateHealthPoint();

        if (Input.GetKeyDown(KeyCode.Q))
        { health -= 10;
            Debug.Log("Health" + health);
        }

        //saran dari genta bisa pake else if saja dan jangan if if semua.
        else if (Input.GetKeyDown(KeyCode.E))
        { health += 50;
            Debug.Log("Health" + health);
        }

        if (health <= 0)
        { gameOver.SetActive(true);
            health = 0;
        }

    }

    /*private void updateHealthPoint()
    {
        if (healthPoint != null)
        {
            int currentHealth = int.Parse(healthPoint.text);
            int newHealth = currentHealth + health;
            healthPoint.text = newHealth.ToString();
        }
        else
        {
            Debug.LogWarning("tidak ada TMP text health");
        }
    }*/
}
