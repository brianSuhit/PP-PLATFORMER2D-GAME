using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameWinningController : MonoBehaviour
{
    [SerializeField] private GameObject gameWinningMenu;

    [SerializeField] private string buttonToMenu = "add level name here";
    [SerializeField] private string buttonToResetGame = "add level name here";
    [SerializeField] private GameObject FirstButtonSelected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameWinningMenu.SetActive(true);
        }
    }

    public void ResetButton()
    {
        SceneManager.LoadScene(buttonToResetGame);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(FirstButtonSelected, new BaseEventData(eventSystem));
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(buttonToMenu);
    }
}
