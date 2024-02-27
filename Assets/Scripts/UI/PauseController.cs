using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    [Header("Others Settings")]
    [SerializeField] private AudioSource levelMusic;
    [SerializeField] private GameObject pauseMenu;

    [Header("Buttons Settings")]
    [SerializeField] private string buttonToMenu;
    [SerializeField] private GameObject eventSystemButtonSelected;
    [SerializeField] private GameObject eventSystemSecondButtonSelected;

    public void PauseButton()
    {
        pauseMenu.SetActive(true);
        levelMusic.Pause();
        Time.timeScale = 0f;
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(eventSystemButtonSelected, new BaseEventData(eventSystem));
    }

    public void ResumeButton()
    {
        pauseMenu.SetActive(false);
        levelMusic.Play();
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
