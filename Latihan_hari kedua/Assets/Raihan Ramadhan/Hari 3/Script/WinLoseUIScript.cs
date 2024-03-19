using UnityEngine;
using System;

public class WinLoseUIScript : MonoBehaviour
{
    // GameObject untuk UI WIN
    public GameObject WIN;

    // GameObject untuk UI LOSE
    public GameObject LOSE;

    void Start()
    {
        // Set UI WIN dan UI LOSE menjadi tidak aktif di awal, maka akan dihilangkan.
        WIN.SetActive(false);
        LOSE.SetActive(false);
    }

    void Update()
    {
        // Tombol W untuk memunculkan UI Win 
        if (Input.GetKeyDown(KeyCode.W))
        {
            WIN.SetActive(true);
        }

        // Tombol S untuk memunculkan UI Lose  
        if (Input.GetKeyDown(KeyCode.S))

        {
            LOSE.SetActive(true);
        }
    }
}
