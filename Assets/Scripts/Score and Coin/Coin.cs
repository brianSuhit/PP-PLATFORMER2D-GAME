using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioSource coinSound;
    [SerializeField] private GameObject effect;
    [SerializeField] private float scoreAmount;

    [SerializeField] private Score score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            coinSound.Play();
            score.ScorePoints(scoreAmount);
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
