using UnityEngine;
using static CharacterStateController;

public class PlayerInput : MonoBehaviour
{
        // Enum untuk daftar state
    public enum CharacterState
    {
        Idle,
        Walking,
        Jumping,
        Attacking
    }

    // State awal
    public CharacterState currentState = CharacterState.Idle;

    // Fungsi untuk mengubah state karakter
    public void ChangeState(CharacterState newState)
    {
        currentState = newState;
        // Tambahkan logika animasi atau perubahan yang sesuai dengan setiap state
        Debug.Log("Current State: " + currentState);
    }

    void Update()
    {
        // Untuk melompat
        if (Input.GetKeyDown(KeyCode.Space) && currentState != CharacterState.Jumping)
        {
            ChangeState(CharacterState.Jumping);
        }

        // Untuk berjalan
        if (Input.GetKey(KeyCode.W) && currentState != CharacterState.Jumping)
        {
            ChangeState(CharacterState.Walking);
        }

        // Untuk menyerang
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (currentState == CharacterState.Jumping)
            {
                ChangeState(CharacterState.Attacking);
            }
            // Jika dalam state berjalan, karakter akan tetap berjalan saat menyerang
            else if (currentState == CharacterState.Walking)
            {
                Debug.Log("Attacking while walking...");
                // Tambahkan logika serangan saat berjalan di sini
            }
        }
    }

    //public CharacterStateController stateController;

    /// <summary>
    /// 
    /// </summary>
    /*void Update()
    {
        // Untuk melompat
        if (Input.GetKeyDown(KeyCode.Space) && stateController.currentState != CharacterState.Jumping)
        {
            stateController.ChangeState(CharacterState.Jumping);
        }

        // Untuk berjalan
        if (Input.GetKey(KeyCode.W) && stateController.currentState != CharacterState.Jumping)
        {
            stateController.ChangeState(CharacterState.Walking);
        }

        // Untuk menyerang
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (stateController.currentState == CharacterState.Jumping)
            {
                stateController.ChangeState(CharacterState.Attacking);
            }
            // Jika dalam state berjalan, karakter akan tetap berjalan saat menyerang
            else if (stateController.currentState == CharacterState.Walking)
            {
                Debug.Log("Attacking while walking...");
                // Tambahkan logika serangan saat berjalan di sini
            }
        }
    }*/

}
