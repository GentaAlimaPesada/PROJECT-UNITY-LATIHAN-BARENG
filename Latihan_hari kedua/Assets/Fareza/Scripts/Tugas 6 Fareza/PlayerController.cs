using UnityEngine;

namespace Tugas6
{
    public class PlayerController : MonoBehaviour 
    {
        [Header("Movement Settings")]
        [SerializeField] private float moveSpeed = 5f;
        [SerializeField] private float jumpForce = 10f;

        private Rigidbody2D rb;
        private bool isGrounded = false;

        private enum PlayerState
        {
            Idle,
            Walking,
            Jumping
        }
        private PlayerState currentState = PlayerState.Idle;

        private void Start() => rb = GetComponent<Rigidbody2D>();
        
        private void Update()
        {
            HandleInput();
            HandlePlayerState();
        }

        private void HandleInput()
        {
            float moveInput = Input.GetAxisRaw("Horizontal");
            
            if (moveInput != 0)
                ChangeState(PlayerState.Walking);
            else if (Input.GetButtonDown("Jump") && isGrounded)
                ChangeState(PlayerState.Jumping);
            else
                ChangeState(PlayerState.Idle);
        }

        private void HandlePlayerState()
        {
            switch (currentState)
            {
                case PlayerState.Idle:
                    break;
                case PlayerState.Walking:
                    HandleWalking();
                    break;
                case PlayerState.Jumping:
                    HandleJumping();
                    break;
            }
        }

        private void HandleWalking()
        {
            float moveInput = Input.GetAxisRaw("Horizontal");
            
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
            if (moveInput < 0)
                transform.localScale = new Vector3(-1, 1, 1);
            else if (moveInput > 0)
                transform.localScale = new Vector3(1, 1, 1);
        }

        private void HandleJumping() => rb.velocity = new Vector2(rb.velocity.x, jumpForce);

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
                isGrounded = true;
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
                isGrounded = false;
        }

        private void ChangeState(PlayerState newState) => currentState = newState;
    }
}