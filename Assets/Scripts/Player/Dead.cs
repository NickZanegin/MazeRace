using UnityEngine;
using DG.Tweening;

public class Dead : MonoBehaviour
{
    [SerializeField] ParticleSystem death;
    [SerializeField] CameraFolow camera;
    [SerializeField] Move move;
    Vector3 startPoint;
    private void Start()
    {
        startPoint = gameObject.transform.localPosition;
    }
    public void Restart()
    {
        move.enabled = false;
        death.transform.position = transform.position;
        death.Play();
        camera.enabled = false;
        gameObject.transform.position = startPoint;
        var cameraStart = new Vector3(transform.position.x, camera.transform.position.y, transform.position.z - 5.138f);
        var cameraMove = DOTween.Sequence();
        cameraMove.Append(camera.gameObject.transform.DOMove(cameraStart, 1));
        cameraMove.AppendCallback(() => Active());
    }
    private void Active()
    {
        camera.enabled = true;
        move.enabled = true;
    }
}
