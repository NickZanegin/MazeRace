using System.Collections;
using System;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class StartTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] string[] textTimer;
    public Action eventStart;
    Vector3 upScale;
    private void Start()
    {
        upScale = new Vector3(4, 4, 1);
        StartCoroutine(Timer());
    }
    IEnumerator Timer()
    {
        var wait = new WaitForSeconds(1);
        var backScale = Vector3.one;
        UpScale(0);
        yield return wait;
        timer.gameObject.transform.localScale = backScale;
        UpScale(1);
        yield return wait;
        timer.gameObject.transform.localScale = backScale;
        UpScale(2);
        yield return wait;
        timer.gameObject.transform.localScale = backScale;
        UpScale(3);
        yield return wait;
        timer.gameObject.SetActive(false);
        eventStart?.Invoke();
    }
    private void UpScale(int index)
    {
        timer.text = textTimer[index];
        timer.gameObject.transform.DOScale(upScale, 0.5f);
    }
}
