using UnityEngine;

public class AdvicePoster : MonoBehaviour
{
    public bool isPlayerInRange;

    [SerializeField] private string playerTag = "Player";
    [SerializeField] private GameObject posterMark;
    [SerializeField] private GameObject advicePosterPanel;

    /// <summary>
    /// This method activates canvas with the tutorial text and deactivates the interaction icon.
    /// </summary>
    public void StartDialogue()
    {
        posterMark.SetActive(false);
        advicePosterPanel.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            isPlayerInRange = true;
            posterMark.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            isPlayerInRange = false;
            posterMark.SetActive(false);
            if (advicePosterPanel != null)
            {
                advicePosterPanel.SetActive(false);
            }
        }
    }
}
