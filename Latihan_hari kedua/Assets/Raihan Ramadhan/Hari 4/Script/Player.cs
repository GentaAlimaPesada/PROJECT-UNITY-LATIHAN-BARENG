using UnityEngine;

namespace PlyrRaihan
{
    public class Player : MonoBehaviour, IHealable
    {
        public void Heal(int amount)
        {
            Debug.Log("Player heals for " + amount + " health.");
        }
    }
}
