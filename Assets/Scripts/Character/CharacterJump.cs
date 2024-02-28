using UnityEngine;

public delegate void Action();

public class CharacterJump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody2D;
    [SerializeField] private float jumpForce;
    [SerializeField] private float fallingGravityScale;

    private float _normalGravityScale;
    private bool _shouldJump;

    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private LayerMask Ground;

    public bool isJumping = false;
    public bool isFalling = false;

    public Action onJump;

    private void OnEnable()
    {
        if (rigidBody2D)
        {
            _normalGravityScale = rigidBody2D.gravityScale;
        }

        if (!rigidBody2D)
        {
            Debug.Log(message: $"{name}: rigidbody2D is null"
                             + $"\nDisabling to avoid nullReference");
            enabled = false;
        }

        if (!boxCollider)
        {
            Debug.Log(message: $"{name}: boxCollider is null"
                             + $"\nDisabling to avoid nullReference");
            enabled = false;
        }
    }

    public void Jump()
    {
        _shouldJump = true;
    }

    private void FixedUpdate()
    {
        isJumping = rigidBody2D.velocity.y > .1f;
        isFalling = rigidBody2D.velocity.y < -.1f;

        if (_shouldJump && IsGrounded())
        {
            rigidBody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            _shouldJump = false;

            if (onJump != null)
            {
                onJump();
            }
        }

        if (rigidBody2D.velocity.y < 0)
        {
            rigidBody2D.gravityScale = fallingGravityScale;
        }
        else
        {
            rigidBody2D.gravityScale = _normalGravityScale;
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down, .1f, Ground);
    }
}
