using UnityEngine;
using UnityEngine.AI;

public class MoveToPoints : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Finish finish;
    [SerializeField] Animator animator;
    [SerializeField] private Transform[] points;
    int pointIndex = 0;
    public bool finished = false; 
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
            Start();
            if(pointIndex == points.Length -1)
            {
                finished = true;
            }
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
}
