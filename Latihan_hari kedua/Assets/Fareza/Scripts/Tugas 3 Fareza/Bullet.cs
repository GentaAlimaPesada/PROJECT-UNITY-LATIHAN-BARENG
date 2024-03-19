using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = rb.velocity = transform.right * bulletSpeed;
        StartCoroutine(DestoyObject());
    }

    IEnumerator DestoyObject()
    {
        float destroyTime = 2f;
        yield return new WaitForSeconds(destroyTime);
        Destroy(gameObject);
    }
}
