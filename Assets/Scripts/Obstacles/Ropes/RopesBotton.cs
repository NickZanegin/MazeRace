using System;
using UnityEngine;

public class RopesBotton : MonoBehaviour
{
    public Action eventButtonTap; 
    private void OnTriggerEnter(Collider other)
    {
        eventButtonTap?.Invoke();
    }
}
