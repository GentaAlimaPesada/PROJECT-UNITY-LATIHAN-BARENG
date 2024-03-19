using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinDisplay : MonoBehaviour
{
    public TMP_Text coinText;

    private void Start()
    {
        // Mendapatkan instance CoinManager menggunakan Service Locator
        CoinManager coinManager = ServiceLocator.GetCoinManager();

        // Mengupdate teks pada UI untuk menampilkan jumlah koin saat ini
        UpdateCoinDisplay(coinManager.GetCoinCount());
    }

    // Method untuk mengupdate tampilan jumlah koin pada UI
    public void UpdateCoinDisplay(int coinCount)
    {
        coinText.text = "Coins: " + coinCount.ToString();
    }
}
