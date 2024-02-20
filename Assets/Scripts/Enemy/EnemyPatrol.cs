using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] CharacterMovement characterMovement;

    [SerializeField] private GameObject[] patrolPoints;

    private int _currentPatrolPointIndex = 0;

    private void Update()
    {

        if (patrolPoints == null)
        {
            Debug.LogError($"{name}: patrolPoints is null!");
        }
        else
        {
            Vector2 targetPoint = patrolPoints[_currentPatrolPointIndex].transform.position;

            float targetDistance = Vector2.Distance(transform.position, targetPoint);

            if (targetDistance < 0.1f)
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
        }
    }
}
