using UnityEngine;
using DG.Tweening;

public class ZoomCamera : MonoBehaviour
{
    [SerializeField] Finish finish;
    int zoom = 25;
    float time = 2;
    [SerializeField] Camera camera;

    private void Start()
    {
        finish.eventWinn += Zoom;
    }
    private void Zoom()
    {
        camera.DOFieldOfView(zoom, time);
    }
}
