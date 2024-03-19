
using UnityEngine;
using UnityEngine.UI;

public class VolumeSound : MonoBehaviour
{
    // Volume slider 
    [SerializeField] Slider volumeSlider;


    private void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume")) // Haskey digunakan untuk mengatur Volume.
        {
            PlayerPrefs.SetFloat("musicVolume", 1); // velue tertinggi suara 0 - 1
        }

        else
        {
            Load(); // untuk menyimpan velue slider 
        }
    }

    // class untuk memanggil slidermya
    public void MengubahVolume() 
    {
        AudioListener.volume = volumeSlider.value;
    
    }

    // class untuk memanggil nilai velue dari besar kecil suara
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
