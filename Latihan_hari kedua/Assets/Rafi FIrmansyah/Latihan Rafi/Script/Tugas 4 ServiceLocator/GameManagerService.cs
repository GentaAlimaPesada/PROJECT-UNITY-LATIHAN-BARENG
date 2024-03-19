using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SrvLctrRafi;

public class GameManagerService : MonoBehaviour
{
    private void Start()
    {
        // Registrasi layanan saat permainan dimulai
        IGameInfoService gameInfoService = new GameInfoService();
        ServiceLocator.RegisterService<IGameInfoService>(gameInfoService);

        // Menggunakan layanan yang didaftarkan
        IGameInfoService retrievedService = ServiceLocator.GetService<IGameInfoService>();
        if (retrievedService != null)
        {
            Debug.Log("Game Name: " + retrievedService.GetGameName());
            Debug.Log("Player Score: " + retrievedService.GetPlayerScore());

            // Mengubah skor pemain dan mendapatkan skor terbaru
            retrievedService.SetPlayerScore(100);
            Debug.Log("Updated Player Score: " + retrievedService.GetPlayerScore());
        }
    }
}
