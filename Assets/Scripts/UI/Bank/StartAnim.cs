using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class StartAnim : MonoBehaviour
{
    [SerializeField] Image[] keys;
    [SerializeField] Sprite noKey;
    [SerializeField] float speed;
    Vector3 point;
    bool start = false;
    public void AnimBank()
    {
        for (int i = 0; i < keys.Length; i++)
        {
            keys[i].sprite = noKey;
        }
        point = new Vector3(transform.localPosition.x, transform.localPosition.y - 481, transform.localPosition.z);
        transform.DOScale(1, speed);
        start = true;
    }
    private void Update()
    {
        if (start)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, point, speed * Time.deltaTime);
            if(Vector3.Distance(transform.position, point) < 3)
            {
                start = false;
                this.enabled = false;
            }
        }
    }
}
