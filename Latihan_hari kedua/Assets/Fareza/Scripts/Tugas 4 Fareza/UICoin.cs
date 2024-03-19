using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class untuk mengontrol UI Coin dan mengimplementasikan interface ICollectable.
/// </summary>
public class UICoin : MonoBehaviour, ICollectable
{
    private int totalCoins;
    [SerializeField] private Text coinText;

    /// <summary>
    /// Update UI nilai dari Coin yang diterima.
    /// </summary>
    private void UpdateCoinText() => coinText.text = totalCoins.ToString();

    /// <summary>
    /// Mengumpulkan jumlah Coin.
    /// </summary>
    /// <param name="amount">Jumlah Coin yang diterima.</param>
    public void CollectItem(int amount)
    {
        totalCoins += amount;
        UpdateCoinText();
    }
}