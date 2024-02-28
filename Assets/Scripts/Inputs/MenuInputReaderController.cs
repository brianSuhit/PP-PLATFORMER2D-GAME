using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInputBehaviour : MonoBehaviour
{
    [SerializeField] private string startButton = "add level name here";

    /// <summary>
    /// This method init the game.
    /// </summary>
    public void StartButton()
    {
        SceneManager.LoadScene(startButton);
    }

    /// <summary>
    /// This method terminates the game/application gracefully.
    /// </summary>
    public void ExitButton()
    {
        Application.Quit();
    }
}

