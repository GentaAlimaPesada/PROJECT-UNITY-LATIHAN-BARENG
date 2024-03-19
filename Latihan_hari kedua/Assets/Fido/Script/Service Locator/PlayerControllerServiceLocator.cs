using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerServiceLocator : MonoBehaviour
{
    public float speed; // Kecepatan pergerakan

    private Rigidbody2D rb;

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
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            // Mendapatkan instance CoinManager menggunakan Service Locator
            CoinManager coinManager = ServiceLocator.GetCoinManager();

            // Menambah jumlah koin saat pemain mengambil koin
            coinManager.AddCoin(1);

            // Menghapus koin dari layar setelah diambil
            Destroy(collision.gameObject);
        }
    }
}
