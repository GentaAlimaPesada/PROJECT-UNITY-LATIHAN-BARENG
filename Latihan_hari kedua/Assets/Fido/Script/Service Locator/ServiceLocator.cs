using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SrvLctrFido
{
    public class ServiceLocator
    {
        private static CoinManager _coinManagerInstance;

        // Method untuk mendapatkan instance CoinManager
        public static CoinManager GetCoinManager()
        {
            if (_coinManagerInstance == null)
            {
                _coinManagerInstance = GameObject.FindObjectOfType<CoinManager>();
            }
            return _coinManagerInstance;
        }
    }
}

