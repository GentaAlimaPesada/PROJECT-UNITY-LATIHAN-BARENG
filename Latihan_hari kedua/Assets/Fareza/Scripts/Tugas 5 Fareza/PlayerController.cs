using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tugas5
{
    public enum PlayerState
    {
        Player1,
        Player2,
    }
    
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 5f;
        [SerializeField] private Transform movePoint;
        [SerializeField] private LayerMask whatStopsMovement;
        [SerializeField] private PlayerState playerState;
        private bool isMovementFinished = false;


        void Start() => movePoint.parent = null;

        void Update()
        {
            if (MoveManager.instance.GetCurrentPlayer() == playerState)
                HandleMovement();

            if (Input.GetKeyDown(KeyCode.Space) && isMovementFinished)
            {
                MoveManager.instance.SwitchPlayerTurn();
                isMovementFinished = false;
            }
        }

        private void HandleMovement()
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, movePoint.position) <= 0.05f)
            {
                if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
                {
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), 0.2f, whatStopsMovement))
                    {
                        movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                        isMovementFinished = true;
                    }
                }
                if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
                {
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), 0.2f, whatStopsMovement))
                    {
                        movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                        isMovementFinished = true;
                    }
                }
            }
        }
    }
}

