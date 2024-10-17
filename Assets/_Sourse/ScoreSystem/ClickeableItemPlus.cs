using UnityEngine;
using ScoreSystem;

public class ClickeableItemPlus : MonoBehaviour
{
    private Score _score;

    public void Construct(Score score)
    {
        _score = score;
    }

    private void OnMouseDown()
    {
        Debug.Log($"Click on {gameObject.name}");
        _score.AddScore(1);
    }
}
