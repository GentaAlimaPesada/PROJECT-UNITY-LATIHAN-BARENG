using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pintu : MonoBehaviour
{

    [SerializeField] private GameObject informationText;
    private bool isOpen;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isOpen)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            Debug.Log("Maaf Koin Kurang");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            informationText.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            informationText.SetActive(false);
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
       if (UI_Manager.coinCollected == 30 && other.gameObject.CompareTag("Player"))
        {
            isOpen = true;
        }
    }
}
