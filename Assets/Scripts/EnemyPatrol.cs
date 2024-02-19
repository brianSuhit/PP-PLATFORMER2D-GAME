using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] CharacterMovement characterMovement;

    //[SerializeField] private List<Vector2> positions;

    [SerializeField] private GameObject[] patrolPoints;

    //[SerializeField] private float threshold = 0.0001f;
    private int _currentPatrolPointIndex = 0;

    private void Update()
    {

        if (patrolPoints == null)
            Debug.LogError($"{name}: Target is null!");

        else
        {
            Vector2 targetPoint = patrolPoints[_currentPatrolPointIndex].transform.position;

            float targetDistance = Vector2.Distance(transform.position, targetPoint);

            if (targetDistance < .1f)
            {
                _currentPatrolPointIndex++;

                if (_currentPatrolPointIndex >= patrolPoints.Length)
                {
                    _currentPatrolPointIndex = 0;
                }
            }

            Vector2 currentPosition = transform.position;
            Vector2 nextPosition = targetPoint;

            Vector2 nextTargetPosition = nextPosition - currentPosition;
            nextTargetPosition.Normalize();

            characterMovement.SetDirection(nextTargetPosition);

            //if ((currentPosition - nextPosition).magnitude <= threshold )
            //{
            //    _currentIndex++;
            //    if ( _currentIndex >= positions.Count ) 
            //    { 
            //        _currentIndex = 0;
            //    }
            //}
        }
    }
}
