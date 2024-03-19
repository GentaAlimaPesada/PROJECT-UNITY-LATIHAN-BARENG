using UnityEngine;
using TMPro;

public class ResourceButton : MonoBehaviour
{
    public int goldToAdd = 100; // Jumlah gold yang ingin ditambahkan setiap kali tombol diklik
    public int woodsToAdd = 200; // Jumlah kayu yang ingin ditambahkan setiap kali tombol diklik

    public TextMeshProUGUI Gold;
    public TextMeshProUGUI Woods;

    private int currentGold = 0; // Jumlah gold saat ini
    private int currentWoods = 0; // Jumlah kayu saat ini

    void Start()
    {
        // Ambil nilai awal gold dan kayu
        currentGold = PlayerPrefs.GetInt("Gold", 0);
        currentWoods = PlayerPrefs.GetInt("Woods", 0);
        UpdateUI();
    }

    private void Update()
    {
        // Mendeteksi input tombol Q
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Reset sumber daya ke 0
            PlayerPrefs.SetInt("Gold", 0);
            PlayerPrefs.SetInt("Woods", 0);

            // Update teks UI
            UpdateUI();
        }
    }

    public void OnResourceButtonClick()
    {
        // Tambahkan gold dan kayu
        currentGold += goldToAdd;
        currentWoods += woodsToAdd;

        // Simpan nilai gold dan kayu
        PlayerPrefs.SetInt("Gold", currentGold);
        PlayerPrefs.SetInt("Woods", currentWoods);

        UpdateUI();
        Debug.Log("Resource Bertambah");
    }

    void UpdateUI()
    {
        // Perbarui teks UI dengan nilai yang baru
        if (Gold != null)
            Gold.text = "Gold: " + PlayerPrefs.GetInt("Gold", 0);

        if (Woods != null)
            Woods.text = "Woods: " + PlayerPrefs.GetInt("Woods", 0);
    }
}
