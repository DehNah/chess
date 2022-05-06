using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int playerOne = 1;
    private int playerTwo = 2;
    public int playerTurn = 0;

    void Start()
    {
        playerTurn = playerOne;
    }

    private void Update()
    {
        SwitchTurns(playerTurn);
    }

    private void SwitchTurns(int currentPlayer)
    {
        if (currentPlayer == playerOne)
        {
            playerTurn = playerTwo;
        }
        else if (currentPlayer == playerTwo)
        {
            playerTurn = playerOne;
        }
    }
}
