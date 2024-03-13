using UnityEngine;

/// <summary>
/// Class untuk mengontrol koin.
/// </summary>
public class Coin : MonoBehaviour 
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            var playerCollect = ServicesLocator.GetService<ICollectable>();
            playerCollect.CollectItem(1);
            Destroy(gameObject);
        }
    }
}