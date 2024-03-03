using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    [Header("Audio Settings")]
    [SerializeField] private AudioSource levelMusic;
    [SerializeField] private AudioSource loseMusic;

    [Header("Buttons Settings")]
    [SerializeField] private string buttonToMenu = "add level name here";
    [SerializeField] private string buttonToResetGame = "add level name here";
    [SerializeField] private GameObject FirstButtonSelected;

    [Header("Others Settings")]
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private HealthPoints playerHealthPoints;

    private void Update()
    {
        EndLevel();
    }

    /// <summary>
    /// This method activates the game over menu and forces the first button of the menu where the courses will be.
    /// </summary>
    public void SetGameOverScreen()
    {
        gameOverMenu.SetActive(true);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(FirstButtonSelected, new BaseEventData(eventSystem));
    }

    /// <summary>
    /// This method reset the game after lose.
    /// </summary>
    public void RestartButton()
    {
        SceneManager.LoadScene(buttonToResetGame);
    }

    /// <summary>
    /// This method loads the main menu scene.
    /// </summary>
    public void MenuButton()
    {
        SceneManager.LoadScene(buttonToMenu);
    }

    /// <summary>
    /// This method checks the player's health and activates the game over menu.
    /// </summary>
    public void EndLevel()
    {
        if (playerHealthPoints.health <= 0)
        {
            gameOverMenu.SetActive(true);
            levelMusic.Pause();
        }
    }
}
