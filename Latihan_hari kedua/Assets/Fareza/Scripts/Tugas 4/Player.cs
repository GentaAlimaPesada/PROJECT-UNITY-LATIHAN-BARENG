using UnityEngine;

/// <summary>
/// Class untuk mengontrol pemain.
/// </summary>
public class Player : MonoBehaviour 
{
    /// <summary>
    /// Mengambil nilai Register dari Interface berdasarkan UICoin
    /// </summary>
    private void Start() 
    {
        ServicesLocator.Register<ICollectable>(FindObjectOfType<UICoin>());
    }
}