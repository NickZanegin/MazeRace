using System.Collections;
using UnityEngine;

public class FurnitureDestroy : MonoBehaviour
{
    [SerializeField] Rigidbody[] rigidbodies;
    [SerializeField] BoxCollider[] boxColliders;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>() || other.GetComponent<Enemy>())
        {
            for (int i = 0; i < rigidbodies.Length; i++)
            {
                rigidbodies[i].isKinematic = false;
            }
            StartCoroutine(WaitDestroy());
        }
    }
    IEnumerator WaitDestroy()
    {
        yield return new WaitForSeconds(3);
        for (int i = 0; i < boxColliders.Length; i++)
        {
            boxColliders[i].enabled = false;
            Destroy(rigidbodies[i]);
        }
        Destroy(this);
    }
}
