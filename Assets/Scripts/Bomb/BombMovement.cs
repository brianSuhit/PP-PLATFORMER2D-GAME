using UnityEngine;

public class BombMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    private Vector2 _initialForce;

    [SerializeField] private Rigidbody2D playerRB;

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();

        if (playerRB == null)
        {
            Debug.LogError("BombMovement requires a Rigidbody component!");
            enabled = false;
        }
    }

    private void FixedUpdate()
    {
        if (_initialForce != Vector2.zero)
        {
            playerRB.AddForce(_initialForce * speed, ForceMode2D.Impulse);
            _initialForce = Vector2.zero;
        }
    }

    public void SetDirection(Vector2 force)
    {
        _initialForce = force;
    }
}
