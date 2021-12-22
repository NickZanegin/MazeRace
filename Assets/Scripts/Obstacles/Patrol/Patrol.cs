using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    WaitForSecondsRealtime thinking;
    [SerializeField] Transform[] points;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] int thinkingTime = 4;
    int pointIndex = 0;
    void Start()
    {
        thinking = new WaitForSecondsRealtime(thinkingTime);
        GoToNewPoint();
    }
    private void GoToNewPoint()
    {
        agent.SetDestination(points[pointIndex].position);
    }
    private void Update()
    {
        if (Vector3.Distance(transform.position, points[pointIndex].position) < 0.5)
        {
            StartCoroutine(WaitThinking());
        }
    }
    IEnumerator WaitThinking()
    {
        pointIndex++;
        if (pointIndex == points.Length)
        {
            pointIndex = 0;
        }
        yield return thinking;
        GoToNewPoint();
    }
}
