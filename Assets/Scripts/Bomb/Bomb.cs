using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private GameObject bombPrefab;
    [SerializeField] private Transform bombPoint;

    [ContextMenu("Throw")]
    public void Throw()
    {
        Instantiate(bombPrefab, bombPoint.position, transform.rotation);
    }
}
