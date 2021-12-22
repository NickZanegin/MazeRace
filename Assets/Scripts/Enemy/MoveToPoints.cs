using System;
using UnityEngine;
using UnityEngine.AI;

public class MoveToPoints : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Finish finish;
    [SerializeField] Animator animator;
    [SerializeField] int[] NuberKeyPoint; 
    [SerializeField] private Transform[] points;
    int pointIndex = 0;
    int nextKeyIndex = 0;
    public bool finished = false;

    public Action eventNewKey;
    private void Start()
    {
        agent.SetDestination(points[pointIndex].position);
        finish.eventFaill += Winn;
        finish.eventWinn += Faill;
    }
    private void Update()
    {
        if (pointIndex < points.Length && Vector3.Distance(transform.position, points[pointIndex].position) < 1)
        {
            pointIndex++;
            if(pointIndex == points.Length-1)
            {
                finished = true;
            }
            if(pointIndex != points.Length)
            {
                Start();
            }
        }
        if (nextKeyIndex < 3 && pointIndex == NuberKeyPoint[nextKeyIndex])
        {
            nextKeyIndex++;
            eventNewKey?.Invoke();
        }
    }
    private void Faill()
    {
        animator.SetBool("NoWay", true);
        agent.Stop();
    }
    private void Winn()
    {
        agent.Stop();
        animator.SetBool("Finish", true);
    }
    public void Restart()
    {
        agent.SetDestination(points[pointIndex].position);
    }
}
