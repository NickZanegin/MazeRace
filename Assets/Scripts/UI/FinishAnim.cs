using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FinishAnim : MonoBehaviour
{
    [SerializeField] Button next;
    [SerializeField] Image text;
    [SerializeField] Image[] stars;
    private void OnEnable()
    {
        var anim = DOTween.Sequence();
        anim.Append(text.DOFade(1, 1));
        anim.Append(stars[0].DOFade(1, 0.5f));
        anim.Append(stars[1].DOFade(1, 0.5f));
        anim.Append(stars[2].DOFade(1, 0.5f));
        //anim.AppendCallback(() => StartCoroutine(WaitToNext()));
    }
    //IEnumerator WaitToNext()
    //{
    //    yield return new WaitForSecondsRealtime(3);
    //    if (next.gameObject.activeInHierarchy)
    //    {
    //        next.gameObject.GetComponent<Button>().onClick.Invoke();
    //    }
    //}
}
