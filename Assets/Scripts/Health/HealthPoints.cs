using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] private int HP = 3;

    public void TakeDamage(int damage)
    {
        HP -= damage;
    }
}
