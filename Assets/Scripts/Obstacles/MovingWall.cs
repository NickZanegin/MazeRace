using UnityEngine;
using DG.Tweening;

public class MovingWall : MonoBehaviour
{
    [SerializeField] Transform point;
    [SerializeField] float speed = 1f;
    void Start()
    {
        transform.DOMove(point.position, speed).SetLoops(-1, LoopType.Yoyo);
    }
}
