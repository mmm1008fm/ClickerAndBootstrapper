using UnityEngine;
using ScoreSystem;

public class ClickeableItem : MonoBehaviour
{
    private Score _score;

    public void Construct(Score score)
    {
        _score = score;
    }

    private void OnMouseDown()
    {
        Debug.Log($"Click on {gameObject.name}");
        _score.AddScore(-1);
        Debug.Log($"Score is {_score.ScoreValue}");
    }
}
