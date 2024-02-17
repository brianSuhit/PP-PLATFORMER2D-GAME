using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] CharacterMovement characterMovement;

    [SerializeField] private List<Vector2> positions;
    [SerializeField] private float threshold = 0.0001f;
    private int _currentIndex = 0;

    private void Update()
    {
        Vector2 nextPosition = positions[_currentIndex];
        Vector2 currentPosition = transform.position;

        Vector2 nextTargetPosition = nextPosition - currentPosition;
        nextTargetPosition.Normalize();

        characterMovement.SetDirection(nextTargetPosition);

        if ((currentPosition - nextPosition).magnitude <= threshold )
        {
            _currentIndex++;
            if ( _currentIndex >= positions.Count ) 
            { 
                _currentIndex = 0;
            }
        }
    }
}
