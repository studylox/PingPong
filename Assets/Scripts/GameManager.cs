using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Text playerScoreText;
    public Text computerScoreText;

    public Paddle playerPaddle;
    public Paddle computerPaddle;

    private int _playerScore;
    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
        playerScoreText.text=_playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;
        computerScoreText.text=_computerScore.ToString();
        ResetRound();
    }

    public void ResetRound()
    {
        this.ball.ResetPosition();
        this.ball.AddStartingForce();


        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();

    }
}
