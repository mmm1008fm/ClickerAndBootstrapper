using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScoreSystem
{
public class Score
{
    public int ScoreValue {get; private set;}
    public void AddScore(int value)
    {
        ScoreValue += value;
        Debug.Log($"Сейчас счет: {ScoreValue}");
    }
    public void SetScore(int value)
    {
        ScoreValue = value;
    }

}
}
