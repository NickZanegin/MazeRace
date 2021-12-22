using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Enemys
{
    public class Dead : MonoBehaviour, IMortal
    {
        [SerializeField] Transform startPoint;
        [SerializeField] MoveToPoints move;
        [SerializeField] NavMeshAgent navMesh;
        [SerializeField] ParticleSystem death;
        public void Restart()
        {
            StartCoroutine(Explosion());
            move.enabled = false;
            navMesh.enabled = false;
            transform.localPosition = startPoint.localPosition;
            StartCoroutine(Waiting());
        }
        IEnumerator Waiting()
        {
            yield return new WaitForSeconds(1);
            move.enabled = true;
            navMesh.enabled = true;
            move.Restart();
        }
        IEnumerator Explosion()
        {
            death.transform.localPosition = transform.position;
            yield return null;
            death.Play();
        }
    }
}
