using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInputBehaviour : MonoBehaviour
{
    [SerializeField] private string startButton = "add level name here";

    /// <summary>
    /// Init the game by loading the designated "startButton" scene.
    /// </summary>
    public void StartButton()
    {
        SceneManager.LoadScene(startButton);
    }

    /// <summary>
    /// Terminates the game/application gracefully.
    /// </summary>
    public void ExitButton()
    {
        Application.Quit();
    }
}

