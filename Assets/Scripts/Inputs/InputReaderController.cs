using UnityEngine;
using UnityEngine.InputSystem;

public class InputReaderController : MonoBehaviour
{
    [SerializeField] private CharacterMovement characterMovement;
    [SerializeField] private Bomb bomb;
    [SerializeField] private CharacterJump characterJump;

    public void SetMovementValue(InputAction.CallbackContext inputContext)
    {
        Vector2 inputValue = inputContext.ReadValue<Vector2>();
        characterMovement.SetDirection(inputValue);

        Debug.Log($"{gameObject.name}: Event risen. Value: {inputValue}");
    }

    public void Shoot(InputAction.CallbackContext inputContext)
    {
        if (inputContext.started)
        {
            if (bomb == null)
            {
                Debug.LogError($"{name} bomb is null");
                return;
            }
            bomb.BombThrow();
        }
    }

    public void Jump(InputAction.CallbackContext inputContext)
    {
        if (inputContext.started)
        {
            if (characterJump == null)
            {
                Debug.LogError($"{name} character jump is null");
                return;
            }
            characterJump.Jump();
        }
    }
}
