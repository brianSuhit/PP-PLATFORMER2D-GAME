using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private string buttonToMenu;

    [SerializeField] private GameObject eventSystemButtonSelected;
    [SerializeField] private GameObject eventSystemSecondButtonSelected;

    public void PauseButton()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(eventSystemButtonSelected, new BaseEventData(eventSystem));
    }

    public void ResumeButton()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(eventSystemSecondButtonSelected, new BaseEventData(eventSystem));
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(buttonToMenu);
        Time.timeScale = 1f;
    }
}
