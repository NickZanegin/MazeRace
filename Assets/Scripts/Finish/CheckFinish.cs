using UnityEngine;
using DG.Tweening;

public class CheckFinish : MonoBehaviour
{
    [SerializeField] Bank bank;
    [SerializeField] ParticleSystem smoke;
    [SerializeField] AddKey[] addKey;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MoveToPoints>() && other.gameObject.GetComponent<MoveToPoints>().finished)
        {
            OpenDoor();
        }
        else if (other.gameObject.GetComponent<Player>() && bank.RetyrnKeys())
        {
            OpenDoor();
        }
    }
    private void OpenDoor()
    {
        gameObject.transform.DOMoveY(transform.position.y - 2, 1.5f);
        smoke.Play();
        for (int i = 0; i < addKey.Length; i++)
        {
            addKey[i].FinishLvl();
        }
    }
}
