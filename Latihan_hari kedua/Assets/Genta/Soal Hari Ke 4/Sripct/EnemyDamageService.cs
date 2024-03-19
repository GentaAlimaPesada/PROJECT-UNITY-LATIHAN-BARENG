using System.Collections;
using System.Collections.Generic;
using System;

/// <summary>
/// Interface untuk layanan yang merusak musuh.
/// </summary>
public interface IEnemyDamageService 
{
    /// <summary>
    /// Metode untuk memberikan damage kepada musuh.
    /// </summary>
    /// <param name="enemy">Nama musuh yang akan menerima damage.</param>
    /// <param name="damageAmount">Jumlah damage yang akan diberikan.</param>
    void DamageEnemy(string enemy, int damageAmount);
}

/// <summary>
/// Implementasi dari layanan untuk merusak musuh.
/// </summary>
public class EnemyDamageService : IEnemyDamageService
{
    /// <summary>
    /// Metode untuk memberikan damage kepada musuh.
    /// </summary>
    /// <param name="enemy">Nama musuh yang akan menerima damage.</param>
    /// <param name="damageAmount">Jumlah damage yang akan diberikan.</param>
    public void DamageEnemy(string enemy, int damageAmount)
    {
        Console.WriteLine($"Memberikan damage sebesar {damageAmount} kepada musuh {enemy}");
    }
}

