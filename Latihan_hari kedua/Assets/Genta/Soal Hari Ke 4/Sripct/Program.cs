using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Kelas utama yang digunakan untuk mengeksekusi program.
/// </summary>
class Program : MonoBehaviour
{
    static void Main(string[] args)
    {
        // Contoh penggunaan layanan damage musuh
        ServiceLocator.EnemyDamageService.DamageEnemy("Goblin", 10);

        // Contoh penggunaan layanan heal pemain
        ServiceLocator.PlayerHealService.HealPlayer("Player1", 20);
    }
}
