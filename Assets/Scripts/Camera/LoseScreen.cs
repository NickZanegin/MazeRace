using UnityEngine;
using DG.Tweening;

public class LoseScreen : MonoBehaviour
{
    [SerializeField] CameraFolow cameraFolow;
    [SerializeField] GameObject faillScreen;

    public void GoToFinish(Vector3 winner)
    {
        cameraFolow.enabled = false;
        var winnerCamera = new Vector3(winner.x, transform.position.y, winner.z - 11);
        var moveCamera = DOTween.Sequence();
        moveCamera.Append(transform.DOMove(winnerCamera, 0.8f));
        moveCamera.AppendCallback(() => Lose());
    }
    private void Lose()
    {
        faillScreen.SetActive(true);
    }
}
