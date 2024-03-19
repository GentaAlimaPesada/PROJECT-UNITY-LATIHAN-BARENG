using UnityEngine;
using System.Collections.Generic;

namespace SrvLctrRaihan
{
    // Class untuk mengatur service locator
    public static class ServiceLocator
    {
        private static Dictionary<System.Type, object> services = new Dictionary<System.Type, object>();

        // Registrasi service
        public static void Register<T>(object implementation)
        {
            services[typeof(T)] = implementation;
        }

        // Mendapatkan service
        public static T Get<T>()
        {
            return (T)services[typeof(T)];
        }
    }
}

// Interface untuk damageable object
public interface IDamageable
{
    void TakeDamage(int amount);
}

// Interface untuk healable object
public interface IHealable
{
    void Heal(int amount);
}
