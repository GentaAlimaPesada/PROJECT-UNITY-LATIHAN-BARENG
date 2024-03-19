using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UseItem : MonoBehaviour, IPointerClickHandler
{
    public string itemName;

    private void Start()
    {
        // Mengecek apakah Image component terdapat pada objek yang memiliki script ini
        Image image = GetComponent<Image>();
        if (image != null)
        {
            // Tidak perlu menambahkan listener untuk event onClick di sini
        }
        else
        {
            Debug.LogError("Script ini membutuhkan UI Image pada objek yang memiliki script ini.");
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Kamu telah menggunakan " + itemName);
        Destroy(gameObject);
    }
}
