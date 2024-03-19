using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] public Vector3 position;
    [SerializeField] public float speed;
    [SerializeField] public int health;
    [SerializeField] public int coins;

    // Event declaration for updating UI
    public delegate void UpdateUIEvent(Vector3 position, float speed, int health, int coins);
    public static event UpdateUIEvent OnUpdateUI;

    void Update()
    {
        // Update player position
        position = transform.position;

        // Example of how speed, health, and coins might change over time
        speed += Time.deltaTime * 0.1f; // Increase speed over time
        health -= Random.Range(0, 2); // Randomly decrease health
        coins += Random.Range(0, 2); // Randomly gain coins

        // Call the method to update UI
        UpdateUI();
    }

    void UpdateUI()
    {
        // Check if there are subscribers to the event
        if (OnUpdateUI != null)
        {
            // Invoke the event, passing current player data
            OnUpdateUI(position, speed, health, coins);
        }
    }
}

public class UIManager : MonoBehaviour
{
    public Text positionText;
    public Text speedText;
    public Text healthText;
    public Text coinsText;

    void Start()
    {
        // Subscribe to the UpdateUI event from Player script
        Player.OnUpdateUI += UpdateUI;
    }

    void UpdateUI(Vector3 position, float speed, int health, int coins)
    {
        // Update UI elements with the new player data
        positionText.text = "Position: " + position.ToString();
        speedText.text = "Speed: " + speed.ToString("F2");
        healthText.text = "Health: " + health.ToString();
        coinsText.text = "Coins: " + coins.ToString();
    }

    // Remember to unsubscribe from events when object is destroyed
    private void OnDestroy()
    {
        Player.OnUpdateUI -= UpdateUI;
    }
}
