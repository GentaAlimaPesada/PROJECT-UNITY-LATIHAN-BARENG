using UnityEngine;
using Tugas5;

public class MoveManager : MonoBehaviour 
{
    public static MoveManager instance { get; private set;}
    private PlayerState currentPlayer;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    private void Start() => currentPlayer = PlayerState.Player1;

    public void SwitchPlayerTurn()
    {
        if (currentPlayer == PlayerState.Player1)
            currentPlayer = PlayerState.Player2;
        else if (currentPlayer == PlayerState.Player2)
            currentPlayer = PlayerState.Player1;
    }

    public PlayerState GetCurrentPlayer()
    {
        return currentPlayer;
    }
}