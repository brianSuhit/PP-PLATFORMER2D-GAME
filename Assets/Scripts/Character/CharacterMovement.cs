using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    public Vector2 _direction;
    private bool _viewRight = true;

    private void Update()
    {
        transform.position = transform.position + new Vector3(_direction.x, _direction.y) * speed * Time.deltaTime;

        if (_direction.x > 0 && !_viewRight)
        {
            Spin();
        }
        else if (_direction.x < 0 && _viewRight)
        {
            Spin();
        }

    }

    /// <summary>
    /// Set the direction and in Update move the object using transform.position
    /// </summary>
    /// <param name="direction">Receive a variable that will be the direction</param>
    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }

    private void Spin()
    {
        _viewRight = !_viewRight;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
    }
}   