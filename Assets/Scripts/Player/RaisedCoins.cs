using System;
using UnityEngine;

public class RaisedCoins : MonoBehaviour
{
    public Action eventPickUp;
    public int keys = 0;
    public void PickUp()
    {
        eventPickUp?.Invoke();
        keys++;
    }
}
