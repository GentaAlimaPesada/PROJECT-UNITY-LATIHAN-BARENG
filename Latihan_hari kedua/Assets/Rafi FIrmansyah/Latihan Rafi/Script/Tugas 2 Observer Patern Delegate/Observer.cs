using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GmMngrRafi;

public class Observer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            GameManager.Instance.SetGameOver(true);
        }
        else if (other.CompareTag("Finished"))
        {
            GameManager.Instance.SetWin(true);

        }
         
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            GameManager.Instance.SetGameOver(false);
        }
        else if (other.CompareTag("Finished"))
        {
            GameManager.Instance.SetWin(false);

        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.Instance.SetPause(true);
        }
    }
}
