using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    [SerializeField] private string coinTag = "Coin";

    [SerializeField] private GameObject effect;
    [SerializeField] private float scoreAmount;
    [SerializeField] private Score score;

    public Action onCollect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(coinTag))
        {
            score.ScorePoints(scoreAmount);
            Instantiate(effect, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);

            if (onCollect != null)
            {
                onCollect();
            }
        }
    }
}
