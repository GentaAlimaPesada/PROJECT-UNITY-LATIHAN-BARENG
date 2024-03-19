using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcInteraction : MonoBehaviour
{
    public GameObject ShopPanel;
    public GameObject arrowIcon;

    private bool PlayerIn = false;

    // Start is called before the first frame update
    void Start()
    {
        PlayerIn = false;
        arrowIcon.SetActive(false);
        ShopPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerIn && Input.GetKeyDown(KeyCode.E))
        {
            ShopPanel.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerIn = true;
            arrowIcon.SetActive(true);

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {   
            PlayerIn = false;
            arrowIcon.SetActive(false);

        }
    }
}
