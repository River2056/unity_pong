using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private float _playerScore;
    private float _computerScore;
    public Text playerScoreUI;
    public Text computerScoreUI;
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreUI.text = this._playerScore.ToString("0");
        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;
        this.computerScoreUI.text = this._computerScore.ToString("0");
        ResetRound();
    }

    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
