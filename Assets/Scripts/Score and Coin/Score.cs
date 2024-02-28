using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private float _points;

    private TextMeshProUGUI _textMesh;

    private void Start()
    {
        _textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        _textMesh.text = _points.ToString("0");
    }

    /// <summary>
    /// This method increases the current score by the value indicated by the points parameter.
    /// </summary>
    /// <param name="points">The amount of points to add to the current score</param>
    public void ScorePoints(float points)
    {
        _points += points;
    }
}
