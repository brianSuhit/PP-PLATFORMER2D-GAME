using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private GameObject bombPrefab;
    [SerializeField] private Transform bombPoint;

    [ContextMenu("Throw")]
    public void BombThrow()
    {
        var boom = Instantiate(bombPrefab, bombPoint.position, transform.rotation);
        var boombMovement = boom.GetComponent<BombMovement>();
        boombMovement.SetDirection(bombPoint.right);
    }
}
