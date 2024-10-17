using System.Collections;
using System.Collections.Generic;
using ScoreSystem;
using UnityEngine;

namespace Core
{
public class Game
{

    private const int _startScoreValue = 5;
    private const int _exitScoreValue = 0;
    private readonly Score _score;

    public Game (Score score)
    {
        _score = score;
        //badPrictise
        //StartGame();
    }
        public void StartGame()
    {
        Debug.Log("StartGame");
        _score.SetScore(_startScoreValue);
    }
        public void FinishGame()
    {
        Debug.Log("FinishGame");
        _score.SetScore(_exitScoreValue);
            Debug.Log($"Сейчас счет: {_exitScoreValue}");
        }

}
}
