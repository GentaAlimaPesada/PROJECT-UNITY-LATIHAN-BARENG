using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfoService : IGameInfoService
{
    private string gameName = "MyGame";
    private int playerScore = 0;

    public string GetGameName()
    {
        return gameName;
    }

    public int GetPlayerScore()
    {
        return playerScore;
    }

    public void SetPlayerScore(int score)
    {
        playerScore = score;
    }
   
}
