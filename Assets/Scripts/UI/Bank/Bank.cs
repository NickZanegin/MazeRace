using System;
using UnityEngine;

public class Bank : MonoBehaviour
{
    [SerializeField] RaisedCoins raisedCoins;
    [SerializeField] RestartState restart;

    public Action eventBankUpdate;
    int keys = 3;
    private void Start()
    {
        raisedCoins.eventPickUp += AddCoins;
        restart.eventRestart += Restart;
    }
    private void AddCoins()
    {
        keys--;
        eventBankUpdate?.Invoke();
    }
    public bool RetyrnKeys()
    {
        if(keys == 0)
        {
            return true;
        }
        return false;
    }
    private void Restart()
    {
        keys = 3;
    }
}
