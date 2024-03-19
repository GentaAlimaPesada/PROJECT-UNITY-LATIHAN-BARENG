using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IntrfcRafi;

public class PlayerMovement : MonoBehaviour
{
    private enum PlayerState
    {
        Idle,
        Walk,
        Jump
    }

    private PlayerState currentState = PlayerState.Idle;

    private bool isGrounded = false;
    //private bool isJumping = false;
    private bool isFacingRight = false;

    float horizontalInput;
    public float movementSpeed = 3f;
    public float jumpPower = 5f;

    private Rigidbody2D rb;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        HandlePlayerState();
        HandleInput();
    
        FlipSprite();
    }

    private void HandlePlayerState()
    {
        switch (currentState)
        {
            case PlayerState.Idle:
                HandleIdleState();
                break;
            case PlayerState.Walk:
                HandleWalkState();
                break;
            case PlayerState.Jump:
                HandleJumpState();
                break;
        }
    }
    
    private void HandleInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && isGrounded) // Memungkinkan lompatan saat tombol "Jump" ditekan dan karakter berada di tanah
            ChangeState(PlayerState.Jump);
        else if (horizontalInput != 0)
            ChangeState(PlayerState.Walk);
        else
            ChangeState(PlayerState.Idle);  
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * movementSpeed, rb.velocity.y);
        animator.SetFloat("xVelocity", Mathf.Abs(rb.velocity.x));
        animator.SetFloat("yVelocity", rb.velocity.y);
    }

    

    void HandleIdleState()
    {
            animator.SetFloat("xVelocity", 0f);
    }

    void HandleWalkState()
    {
        /*horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * movementSpeed, rb.velocity.y);
        
        if (Mathf.Abs(horizontalInput) > 0f)
        {
            animator.SetFloat("xVelocity", Mathf.Abs(horizontalInput));
        }*/

        if (currentState != PlayerState.Jump)
        {
            rb.velocity = new Vector2(horizontalInput * movementSpeed, rb.velocity.y);

            if (Mathf.Abs(horizontalInput) > 0f)
            {
                animator.SetFloat("xVelocity", Mathf.Abs(horizontalInput));
            }
        }

    }

    void HandleJumpState()
    {
        Debug.Log("Kamu meloncat");

        if (isGrounded) // Memastikan karakter hanya bisa melompat saat berada di tanah
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            isGrounded = false;
            animator.SetBool("isJumping", true); // Update animator
        }

        else
        {
            // Biarkan karakter bergerak horizontal saat sedang melompat
            rb.velocity = new Vector2(horizontalInput * movementSpeed, rb.velocity.y);
        }

    }

    private void FlipSprite()
    {
        if (isFacingRight && horizontalInput > 0f || !isFacingRight && horizontalInput < 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out IPickAble pickable))
        {
            pickable.Pickup();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground")) // Mengatur isGrounded hanya saat karakter menyentuh tanah
        {
            isGrounded = true;
            animator.SetBool("isJumping", false); // Update animator
        }


    }

    private void ChangeState(PlayerState newState)
    {
        currentState = newState;
    }
}
