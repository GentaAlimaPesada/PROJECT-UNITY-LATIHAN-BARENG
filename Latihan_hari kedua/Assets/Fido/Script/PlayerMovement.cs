using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlyrMvFido
{
    public class PlayerMovement : MonoBehaviour
    {
        public float speed; // Kecepatan pergerakan

        private Rigidbody2D rb;

        public int damageAmount = 10;

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
            if (collision.CompareTag("Objek"))
            {
                // Mengurangi kesehatan pemain ketika bersentuhan
                collision.GetComponent<ObjekHealth>().TakeDamage(damageAmount);
            }
        }
    }
}

