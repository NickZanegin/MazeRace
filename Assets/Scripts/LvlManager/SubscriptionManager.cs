using UnityEngine;

public class SubscriptionManager : MonoBehaviour
{
    [SerializeField] Move move;
    [SerializeField] LoseScreen loseScreen;
    Finish finish;
    private void Start()
    {
        finish = FindObjectOfType<Finish>();
        Subscribe(finish, FindObjectOfType<Bank>());
    }
    public void Subscribe(Finish finish, Bank bank)
    {
        this.finish = finish;
        finish.eventFaill += move.Faill;
        finish.eventWinn += move.Winn;
        finish.eventFailCamera += loseScreen.GoToFinish;
        finish.SetBank(bank);
    }
    public void Unsubscribe()
    {
        finish.eventFaill -= move.Faill;
        finish.eventWinn -= move.Winn;
        finish.eventFailCamera -= loseScreen.GoToFinish;
    }
}
