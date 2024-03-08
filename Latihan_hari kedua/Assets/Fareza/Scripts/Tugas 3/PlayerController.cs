using System;
using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
    [SerializeField] private float jumpForce;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Rigidbody2D rb;

    private void Start() => rb = GetComponent<Rigidbody2D>();

    private void OnEnable()
    {
        EventManager.OnPlayerJump += Jump; 
        EventManager.OnPlayerShoot += Shoot; 
    }

    private void OnDisable() 
    {
        EventManager.OnPlayerJump -= Jump;   
        EventManager.OnPlayerShoot -= Shoot; 
    }

    private void Jump() => rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    private void Shoot() => Instantiate(bullet, transform.position, transform.rotation);
}