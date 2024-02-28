using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameWinningController : MonoBehaviour
{
    [Header("Audio Settings")]
    [SerializeField] private AudioSource levelMusic;
    [SerializeField] private AudioSource WinningMusic;

    [Header("Buttons Settings")]
    [SerializeField] private string buttonToMenu = "add level name here";
    [SerializeField] private string buttonToResetGame = "add level name here";
    [SerializeField] private GameObject FirstButtonSelected;

    [Header("Others Settings")]
    [SerializeField] private GameObject gameWinningMenu;
    [SerializeField] private string playerTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(playerTag))
        {
            gameWinningMenu.SetActive(true);
            levelMusic.Pause();
        }
    }

    /// <summary>
    /// This method resets the game after win.
    /// </summary>
    public void ResetButton()
    {
        SceneManager.LoadScene(buttonToResetGame);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(FirstButtonSelected, new BaseEventData(eventSystem));
    }

    /// <summary>
    /// This method loads the main menu scene.
    /// </summary>
    public void MenuButton()
    {
        SceneManager.LoadScene(buttonToMenu);
    }
}
