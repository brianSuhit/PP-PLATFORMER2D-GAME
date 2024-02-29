using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] public int health = 100;

    [SerializeField] private bool shouldDestroyOnDeath;

    public void Start()
    {
        health = maxHealth;
    }

    /// <summary>
    /// Applies damage to the object and handles potential destruction upon death.
    /// </summary>
    /// <param name="damage">The amount of damage to be taken</param>
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (shouldDestroyOnDeath && health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
