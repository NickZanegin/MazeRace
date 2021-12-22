using UnityEngine;
using DG.Tweening;

public class Ropes : MonoBehaviour
{
    [SerializeField] RopesTimer timer;
    void Start()
    {
        timer.eventMoveRopes += MoveRope;   
    }
    private void MoveRope()
    {
        if(transform.localPosition == Vector3.zero)
        {
            transform.DOLocalMoveY(73, 1);
        }
        else
        {
            transform.DOLocalMoveY(0, 1);
        }
    }
}
