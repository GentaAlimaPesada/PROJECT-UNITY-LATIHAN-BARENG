using UnityEngine;

public class Mahasiswa : Person 
{
    [Header("Status")]
    [SerializeField] private int NIM;
    [SerializeField] private string prodi;

    public void Announcement() 
    {
        Debug.Log("Dengan NIM : " + NIM + " dan dari Prodi " + prodi);
    }
}