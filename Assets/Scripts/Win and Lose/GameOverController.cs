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

    [Header("Other Settings")]
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private HealthPoints playerHealthPoints;

    private void Update()
    {
        EndLevel();
    }

    public void SetGameOverScreen()
    {
        gameOverMenu.SetActive(true);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(FirstButtonSelected, new BaseEventData(eventSystem));
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(buttonToResetGame);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(buttonToMenu);
    }

    public void EndLevel()
    {
        if (playerHealthPoints.health <= 0)
        {
            gameOverMenu.SetActive(true);
            levelMusic.Pause();
        }
    }
}
