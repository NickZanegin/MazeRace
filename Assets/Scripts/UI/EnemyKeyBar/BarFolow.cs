using UnityEngine;

public class BarFolow : MonoBehaviour
{
    [SerializeField] Camera camera;
    [SerializeField] Transform point;
    Vector3 positionInCanvas;
    void Update()
    {
        positionInCanvas = camera.WorldToScreenPoint(point.position);
        transform.position = positionInCanvas;
    }
}
