using UnityEngine;
using UnityEngine.InputSystem;

public class InputReaderController : MonoBehaviour
{
    [SerializeField] private CharacterMovement characterMovement;
    [SerializeField] private Bomb bomb;
    [SerializeField] private CharacterJump characterJump;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputContext"></param>
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
            characterJump.Jump();
        }
    }
}
