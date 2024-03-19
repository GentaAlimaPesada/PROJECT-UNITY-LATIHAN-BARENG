using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody2D rb; // RigidBody = rb 
    Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // RigidBody 2D 

    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void Gold()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Panggil PlayOneShot dari instance SoundManager
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}
