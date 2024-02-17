using UnityEngine;
using UnityEngine.InputSystem;

public class InputReaderController : MonoBehaviour
{
    [SerializeField] CharacterMovement characterMovement;

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
}
