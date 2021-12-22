using System;
using System.Collections;
using UnityEngine;

public class RopesTimer : MonoBehaviour
{
    public Action eventMoveRopes;
    [SerializeField] float timeDilay = 1f;
    void Start()
    {
        StartCoroutine(RopeTimer());
    }

    IEnumerator RopeTimer()
    {
        var time = new WaitForSeconds(timeDilay);
        while (true)
        {
            yield return time;
            eventMoveRopes?.Invoke();
            yield return null;
        }
    }
}
