using UnityEngine;

public class DestroyWhenLeavingScreen : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
