using System;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] Bank bank;
    [SerializeField] GameObject restart;
    [SerializeField] GameObject winScreen;
    [SerializeField] GameObject jostic;

    public Action eventWinn;
    public Action eventFaill;
    public Action<Transform> eventFailCamera;
    public void OnTriggerEnter(Collider collision)
    {
        restart.SetActive(false);
        jostic.SetActive(false);
        if (collision.gameObject.GetComponent<Player>() && bank.RetyrnKeys())
        {
            winScreen.SetActive(true);
            eventWinn?.Invoke();
            collision.gameObject.GetComponent<Animator>().SetBool("Finish", true);
        }
        else if (collision.gameObject.GetComponent<Enemy>())
        {
            eventFaill?.Invoke();
            collision.gameObject.GetComponent<Animator>().SetBool("Finish", true);
            eventFailCamera?.Invoke(collision.gameObject.transform);
        }
        bank.gameObject.SetActive(false);
    }
    public void SetBank(Bank bank)
    {
        this.bank = bank;
    }
}
