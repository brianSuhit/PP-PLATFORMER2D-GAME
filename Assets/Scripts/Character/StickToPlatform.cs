using UnityEngine;

public class StickToPlatform : MonoBehaviour
{
    [SerializeField] private string playerName = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == playerName)
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == playerName)
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
