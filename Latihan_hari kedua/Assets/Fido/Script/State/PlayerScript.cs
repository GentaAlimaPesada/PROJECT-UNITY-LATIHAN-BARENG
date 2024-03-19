using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D rb;

    [SerializeField]
    private PlayerState currentState;

    public enum PlayerState
    {
        Idle,
        Move,
        Jump
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentState = PlayerState.Idle;
    }

    void Update()
    {
        HandleInput();
        UpdateState();
    }

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void UpdateState()
    {
        switch (currentState)
        {
            case PlayerState.Idle:
                HandleIdleState();
                break;
            case PlayerState.Move:
                HandleMoveState();
                break;
            case PlayerState.Jump:
                HandleJumpState();
                break;
        }
    }

    private void HandleIdleState()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0)
        {
            currentState = PlayerState.Move;
        }
    }

    private void HandleMoveState()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        rb.velocity = movement;

        if (Mathf.Abs(horizontalInput) < Mathf.Epsilon)
        {
            currentState = PlayerState.Idle;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void HandleJumpState()
    {
        // Handle jump logic, for example:
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        currentState = PlayerState.Idle;
    }

    private void Jump()
    {
        if (currentState != PlayerState.Jump)
        {
            currentState = PlayerState.Jump;
        }
    }
}
