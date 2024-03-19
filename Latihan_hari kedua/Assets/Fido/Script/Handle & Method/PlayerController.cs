using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed; // Kecepatan pergerakan

    private Rigidbody2D rb;

    public int coins = 0; // Jumlah awal koin
    public TMP_Text coinText; // UI Text untuk menampilkan jumlah koin

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
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

        UpdateCoinUI();
    }

    public void AddCoin(int value)
    {
        coins += value; // Menambah nilai koin
        UpdateCoinUI();
    }

    void UpdateCoinUI()
    {
        coinText.text = "Coins: " + coins.ToString(); // Memperbarui teks UI
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Area Pintu"))
        {
            if (coins < 30 && Input.GetKeyDown(KeyCode.P))
            {
                Debug.Log("Coin tidak cukup!");
            }
            else if (coins > 30 && Input.GetKeyDown(KeyCode.P))
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
