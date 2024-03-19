using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum CharacterState
{
    Idle,
    Moving,
    Attacking,
    Jumping,
    Interacting
}

public class Controller : MonoBehaviour
{
    private CharacterState currentState = CharacterState.Idle;

    public void ChangeState(CharacterState newState)
    {
        currentState = newState;
        Debug.Log("Character state: " + currentState);
    }
    
    void Update()
    {
        // Untuk melompat
        if (Input.GetKeyDown(KeyCode.I) && currentState != CharacterState.Jumping)
        {
           ChangeState(CharacterState.Idle);
        }

        // Untuk berjalan
        if (Input.GetKey(KeyCode.M) && currentState != CharacterState.Jumping)
        {
           ChangeState(CharacterState.Moving);
        }

        // Untuk menyerang
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (currentState == CharacterState.Jumping)
            {
                ChangeState(CharacterState.Attacking);
            }
            // Jika dalam state berjalan, karakter akan tetap berjalan saat menyerang
            else if (currentState == CharacterState.Moving)
            {
                Debug.Log("Attacking while walking...");
                // Tambahkan logika serangan saat berjalan di sini
            }
        }
    }
}
