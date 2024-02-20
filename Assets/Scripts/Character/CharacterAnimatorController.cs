using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CharacterAnimatorController : MonoBehaviour
{
    private enum MovementState
    {
        idle,
        run,
        jump,
        fall
    }

    [SerializeField] private Animator animator;
    [SerializeField] private CharacterMovement characterMovement;
    [SerializeField] private CharacterJump characterJump;

    [SerializeField] private string animatorParameterState = "state";

    private void Reset()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        MovementState state;

        Vector2 direction = characterMovement._direction;

        bool isMoving = direction != Vector2.zero;

        if (isMoving)
        {
            state = MovementState.run;
        }
        else
        {
            state = MovementState.idle;
        }

        if (characterJump.isJumping)
        {
            state = MovementState.jump;
        }

        else if (characterJump.isFalling)
        {
            state = MovementState.fall;
        }

        animator.SetInteger(animatorParameterState, (int)state);
    }
}
