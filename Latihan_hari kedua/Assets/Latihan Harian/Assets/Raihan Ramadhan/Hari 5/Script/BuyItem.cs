using UnityEngine;

public class BuyItem : MonoBehaviour
{
    [SerializeField] private ResourceButton resourceButton;

    [SerializeField] private int itemGoldCost = 1000;
    [SerializeField] private int itemWoodCost = 1500;

    void Start()
    {
        resourceButton = FindObjectOfType<ResourceButton>(); // Mencari objek dengan komponen ResourceButton di dalam scene
    }

    public void PurchaseItem()
    {
        int currentGold = PlayerPrefs.GetInt("Gold", 0);
        int currentWoods = PlayerPrefs.GetInt("Woods", 0);

        if (currentGold >= itemGoldCost && currentWoods >= itemWoodCost)
        {
            // Mengurangi gold dan kayu yang diperlukan
            currentGold -= itemGoldCost;
            currentWoods -= itemWoodCost;

            // Menyimpan nilai gold dan kayu yang baru
            PlayerPrefs.SetInt("Gold", currentGold);
            PlayerPrefs.SetInt("Woods", currentWoods);

            // Mengupdate UI
            if (resourceButton != null)
                //resourceButton.UpdateUI();

            Debug.Log("Item telah dibeli!");
        }
        else
        {
            Debug.Log("Tidak cukup sumber daya untuk membeli item!");
        }
    }
}
