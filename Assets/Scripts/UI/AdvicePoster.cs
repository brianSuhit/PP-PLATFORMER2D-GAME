using UnityEngine;

public class AdvicePoster : MonoBehaviour
{
    [SerializeField] private GameObject posterMark;
    [SerializeField] private GameObject advicePosterPanel;

    private void Start()
    {
        posterMark.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            posterMark.SetActive(false);
            advicePosterPanel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            posterMark.SetActive(true);
            if (advicePosterPanel != null)
            {
                advicePosterPanel.SetActive(false);
            }
        }
    }
}
