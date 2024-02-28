using UnityEngine;
using UnityEngine.UI;

public class CanvasScalerController : MonoBehaviour
{
    [SerializeField] private CanvasScaler canvasScaler;

    private void OnEnable()
    {
        SetAspectRatioMatch();
    }

    private void Update()
    {
        SetAspectRatioMatch();
    }

    /// <summary>
    /// Adjust the canvas aspect ratio to match the screen.
    /// </summary>
    private void SetAspectRatioMatch()
    {
        float currentAspectRatio = (float)Screen.width / Screen.height;
        float canvasScalerAspectRatio = canvasScaler.referenceResolution.y / canvasScaler.referenceResolution.x;
        canvasScaler.matchWidthOrHeight = canvasScalerAspectRatio > currentAspectRatio ? 1f : 0f;
    }
}
