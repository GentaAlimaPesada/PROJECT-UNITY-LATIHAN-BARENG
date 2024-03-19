using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    private int coinCount = 0;

    // Method untuk menambah jumlah koin
    public void AddCoin(int amount)
    {
        coinCount += amount;
        Debug.Log("Added " + amount + " coins. Total coins: " + coinCount);
        // Di sini Anda juga dapat menambahkan logika lain, seperti update UI, dll.
    }

    // Method untuk mendapatkan jumlah koin saat ini
    public int GetCoinCount()
    {
        return coinCount;
    }
}