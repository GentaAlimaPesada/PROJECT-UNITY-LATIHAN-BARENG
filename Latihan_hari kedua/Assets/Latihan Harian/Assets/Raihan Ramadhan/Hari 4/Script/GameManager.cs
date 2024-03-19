// Class untuk menangani logic damage dan heal
using UnityEngine;
using SrvLctrRaihan;

namespace GmMngrRaihan
{
    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            // Registrasi object-player dan object-enemy sebagai service
            ServiceLocator.Register<IHealable>(GetComponent<Player>());
            ServiceLocator.Register<IDamageable>(GetComponent<Enemy>());

            // Contoh penggunaan
            IDamageable enemy = ServiceLocator.Get<IDamageable>();
            IHealable player = ServiceLocator.Get<IHealable>();

            // Enemy menyerang player
            enemy.TakeDamage(10);

            // Player menggunakan item heal
            player.Heal(20);
        }
    }
}
