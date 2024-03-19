using System.Collections;
using System.Collections.Generic;
using System;

/// <summary>
/// Interface untuk layanan yang menyembuhkan pemain.
/// </summary>
public interface IPlayerHealService 
{
    /// <summary>
    /// Metode untuk menyembuhkan pemain.
    /// </summary>
    /// <param name="player">Nama pemain yang akan disembuhkan.</param>
    /// <param name="healAmount">Jumlah penyembuhan yang akan diberikan.</param>
    void HealPlayer(string player, int healAmount);
}

/// <summary>
/// Implementasi dari layanan untuk menyembuhkan pemain.
/// </summary>
public class PlayerHealService : IPlayerHealService
{
    /// <summary>
    /// Metode untuk menyembuhkan pemain.
    /// </summary>
    /// <param name="player">Nama pemain yang akan disembuhkan.</param>
    /// <param name="healAmount">Jumlah penyembuhan yang akan diberikan.</param>
    public void HealPlayer(string player, int healAmount)
    {
        Console.WriteLine($"Menyembuhkan pemain {player} sebesar {healAmount}");
    }
}
