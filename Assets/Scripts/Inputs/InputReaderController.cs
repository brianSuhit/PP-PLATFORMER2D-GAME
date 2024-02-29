using UnityEngine;
using UnityEngine.InputSystem;

public class InputReaderController : MonoBehaviour
{
    [SerializeField] private CharacterMovement characterMovement;
    [SerializeField] private CharacterJump characterJump;

    [SerializeField] private AdvicePoster advicePoster;

    /// <summary>
    /// Sets the movement direction of the character based on user input.
    /// </summary>
    /// <param name="inputContext">Receives input from the player</param>
    public void SetMovementValue(InputAction.CallbackContext inputContext)
    {
        Vector2 inputValue = inputContext.ReadValue<Vector2>();
        characterMovement.SetDirection(inputValue);

        Debug.Log($"{gameObject.name}: Event risen. Value: {inputValue}");
    }

    /// <summary>
    /// Access the jump method and jump the character.
    /// </summary>
    /// <param name="inputContext">Receives input from the player</param>
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

    /// <summary>
    /// Starts the dialogue text if the player is within range.
    /// </summary>
    /// <param name="inputContext">Receives input from the player</param>
        public void SetStartAdviceDialogue(InputAction.CallbackContext inputContext)
        {
            if (inputContext.started)
            {
                if (advicePoster == null)
                {
                    Debug.LogError($"{name} advice poster is null");
                    return;
                }

                if (advicePoster.isPlayerInRange)
                {
                    advicePoster.StartDialogue();
                }
            }
        }
}
