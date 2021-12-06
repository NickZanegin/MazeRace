using System;
using UnityEngine;

public class RestartState : MonoBehaviour
{
    public Action eventRestart;
    private void Restart()
    {
        eventRestart?.Invoke();
    }
}
