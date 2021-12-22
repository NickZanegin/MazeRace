using UnityEngine;
using DG.Tweening;

public class BoolRopes : MonoBehaviour
{
    [SerializeField] RopesBotton botton;
    [SerializeField] RopesBotton botton2;
    void Start()
    {
        botton.eventButtonTap += MoveRope;
        botton2.eventButtonTap += MoveRope;
    }
    private void MoveRope()
    {
        if (transform.localPosition == Vector3.zero)
        {
            transform.DOLocalMoveY(73, 0.8f);
        }
        else
        {
            transform.DOLocalMoveY(0, 0.8f);
        }
    }
}
