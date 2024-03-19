using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlyrMvFGenta
{
    public class PlayerController : MonoBehaviour
    {
        public float speed = 5f; // Kecepatan pergerakan pemain

        private Rigidbody2D rb; // Referensi ke Rigidbody2D pemain

        void Start()
        {
            // Mencari Rigidbody2D pada pemain, jika ada
            rb = GetComponent<Rigidbody2D>();
            if (rb == null)
            {
                // Jika tidak ada, tambahkan Rigidbody2D
                rb = gameObject.AddComponent<Rigidbody2D>();
                // Set gravitasi menjadi nol agar pemain tidak jatuh
                rb.gravityScale = 0f;
            }
        }

        void Update()
        {
            // Mengambil input dari sumbu horizontal dan vertikal
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            // Menentukan vektor pergerakan berdasarkan input
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);

            // Normalisasi vektor pergerakan agar pemain bergerak dengan kecepatan yang konsisten
            movement = movement.normalized * speed * Time.deltaTime;

            // Menggerakkan pemain menggunakan transform
            transform.Translate(movement);
        }
    }
}


