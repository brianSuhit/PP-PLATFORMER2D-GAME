using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    public float speed = 1.0f;
    public float amplitude = 0.1f;

    void Update()
    {
        float scale = 1.0f + amplitude * Mathf.Sin(Time.time * speed);
        transform.localScale = new Vector3(scale, scale, 1.0f);
    }
}
