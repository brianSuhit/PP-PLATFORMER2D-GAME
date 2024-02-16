using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    private Vector2 _direction;

    private void Update()
    {
        transform.position = transform.position + new Vector3(_direction.x, _direction.y) * speed * Time.deltaTime;
    }

    /// <summary>
    /// Set the direction and in Update move the object using transform.position
    /// </summary>
    /// <param name="direction">Receive a variable that will be the direction</param>
    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }
}