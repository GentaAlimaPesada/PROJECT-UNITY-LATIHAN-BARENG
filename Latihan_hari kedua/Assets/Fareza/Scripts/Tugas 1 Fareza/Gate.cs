using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        Mahasiswa mhsiswa = FindObjectOfType<Mahasiswa>();
        if(other.gameObject.CompareTag("Mahasiswa"))
        {
            mhsiswa.Announcement();
            mhsiswa.Age();
            Destroy(gameObject);
        }
    }
}
