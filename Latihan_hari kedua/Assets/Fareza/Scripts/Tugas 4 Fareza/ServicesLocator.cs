using System;
using System.Collections.Generic;

/// <summary>
/// Class untuk menyimpan dan mendapatkan instance dari layanan-layanan yang diperlukan.
/// </summary>
public static class ServicesLocator
{
    public static readonly Dictionary<Type, object> services = new Dictionary<Type, object>();

    /// <summary>
    /// Mendaftarkan sebuah layanan.
    /// </summary>
    /// <typeparam name="T">Tipe dari layanan yang didaftarkan.</typeparam>
    /// <param name="service">Instance dari layanan yang didaftarkan.</param>
    public static void Register<T>(T service)
    {
        services[typeof(T)] = service;
    }

    /// <summary>
    /// Mendapatkan instance dari layanan yang terdaftar.
    /// </summary>
    /// <typeparam name="T">Tipe dari layanan yang ingin didapatkan.</typeparam>
    /// <returns>Instance dari layanan yang terdaftar.</returns>
    public static T GetService<T>()
    {
        return (T)services[typeof(T)];
    }
}
