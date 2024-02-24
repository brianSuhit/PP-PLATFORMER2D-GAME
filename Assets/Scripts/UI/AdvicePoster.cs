using UnityEngine;

public class AdvicePoster : MonoBehaviour
{
    public bool isPlayerInRange;

    [SerializeField] private GameObject posterMark;
    [SerializeField] private GameObject advicePosterPanel;

    public void StartDialogue()
    {
        posterMark.SetActive(false);
        advicePosterPanel.SetActive(true);
    }

    //private void Start()
    //{
    //    posterMark.SetActive(true);
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            posterMark.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
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
