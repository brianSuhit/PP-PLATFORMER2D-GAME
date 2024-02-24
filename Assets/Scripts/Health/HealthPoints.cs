using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int health = 100;

    [SerializeField] private bool shouldDestroyOnDeath;

    public void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (shouldDestroyOnDeath && health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
