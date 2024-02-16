using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour
{
    [SerializeField] CharacterMovement characterMovement;

    public void SetMovementValue(InputAction.CallbackContext inputContext)
    {
        Vector2 inputValue = inputContext.ReadValue<Vector2>();
        characterMovement.SetDirection(inputValue);

        Debug.Log($"{gameObject.name}: Event risen. Value: {inputValue}");
    }
}
