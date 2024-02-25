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

    public void ScorePoints(float points)
    {
        _points += points;
    }
}
