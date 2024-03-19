using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public int damagePoints;
    private bool canTakeDamage = true;

    private void Start()
    {
        Debug.Log("Health Point " + healthPoints);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.E) && canTakeDamage)
        {
            StartCoroutine(TakeDamageCoroutine());
        }
    }

    IEnumerator TakeDamageCoroutine()
    {
        canTakeDamage = false;
        TakeDamage(damagePoints);

        // Menetapkan cooldown selama 1 detik
        yield return new WaitForSeconds(1f);

        canTakeDamage = true;
    }
}
