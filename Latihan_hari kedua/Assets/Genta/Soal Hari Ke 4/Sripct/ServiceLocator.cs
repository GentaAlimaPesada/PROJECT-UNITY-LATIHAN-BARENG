using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Kelas yang bertanggung jawab untuk menyediakan akses ke layanan-layanan yang ada.
/// </summary>
public class ServiceLocator : MonoBehaviour
{
    // Membuat instance layanan damage musuh sebagai singleton
    private static readonly Lazy<EnemyDamageService> _enemyDamageService = new Lazy<EnemyDamageService>(() => new EnemyDamageService());

    // Membuat instance layanan penyembuhan pemain sebagai singleton
    private static readonly Lazy<PlayerHealService> _playerHealService = new Lazy<PlayerHealService>(() => new PlayerHealService());

    /// <summary>
    /// Properti untuk mendapatkan instance layanan damage musuh.
    /// </summary>
    public static IEnemyDamageService EnemyDamageService => _enemyDamageService.Value;

    /// <summary>
    /// Properti untuk mendapatkan instance layanan penyembuhan pemain.
    /// </summary>
    public static IPlayerHealService PlayerHealService => _playerHealService.Value;
}

