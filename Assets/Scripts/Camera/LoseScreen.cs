using UnityEngine;
using DG.Tweening;

public class LoseScreen : MonoBehaviour
{
    [SerializeField] CameraFolow cameraFolow;
    [SerializeField] GameObject faillScreen;

    public void GoToFinish(Transform winner)
    {
        cameraFolow.enabled = false;
        var winnerCamera = new Vector3(winner.position.x, transform.position.y, winner.position.z - 5.138f);
        var moveCamera = DOTween.Sequence();
        moveCamera.Append(transform.DOMove(winnerCamera, 0.8f));
        moveCamera.AppendCallback(() => Lose());
    }
    private void Lose()
    {
        faillScreen.SetActive(true);
    }
}
