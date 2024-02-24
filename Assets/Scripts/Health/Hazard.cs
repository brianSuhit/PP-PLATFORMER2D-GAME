using UnityEngine;

public class Hazard : MonoBehaviour
{
    [SerializeField] private int damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject playerGameObject = collision.gameObject;

        HealthPoints playerHP = playerGameObject.GetComponent<HealthPoints>();

        if (playerHP != null)
        {
            playerHP.TakeDamage(damage);
        }
        else
        {
            Debug.LogError($"{name}: character health is null");
        }
    }
}
