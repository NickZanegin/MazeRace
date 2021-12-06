using System;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] Bank bank;
    public Action eventWinn;
    public Action eventFaill;
    public Action<Transform> eventFailCamera;
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<Player>() && bank.RetyrnKeys())
        {
            eventWinn?.Invoke();
            collision.gameObject.GetComponent<Animator>().SetBool("Finish", true);
        }
        else if (collision.gameObject.GetComponent<Enemy>())
        {
            eventFaill?.Invoke();
            collision.gameObject.GetComponent<Animator>().SetBool("Finish", true);
            eventFailCamera?.Invoke(collision.gameObject.transform);
        }
    }
    public void SetBank(Bank bank)
    {
        this.bank = bank;
    }
}
