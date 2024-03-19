using UnityEngine;

namespace Tugas4
{
    /// <summary>
    /// Class untuk mengontrol pemain.
    /// </summary>
    public class PlayerController : MonoBehaviour 
    {
        /// <summary>
        /// Mengambil nilai Register dari Interface berdasarkan UICoin
        /// </summary>
        private void Start() 
        {
            ServicesLocator.Register<ICollectable>(FindObjectOfType<UICoin>());
        }
    }
}
