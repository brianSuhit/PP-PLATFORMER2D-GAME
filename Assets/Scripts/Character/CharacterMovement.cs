using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    public Vector2 _direction;

    void Update()
    {
        transform.position = transform.position + new Vector3(_direction.x,0) * speed * Time.deltaTime;
    }

    /// <summary>
    /// Write any here
    /// </summary>
    /// <param name="direction">Write any here</param>
    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }
}