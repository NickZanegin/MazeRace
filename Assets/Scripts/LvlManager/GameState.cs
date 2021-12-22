using UnityEngine;

public class GameState : MonoBehaviour
{
    [SerializeField] Move controller;
    [SerializeField] MoveToPoints[] enemys;
    [SerializeField] StartTimer start;

    private void Start()
    {
        start.eventStart += StartGame;
    }
    private void StartGame()
    {
        CangeState(true);
    }
    private void CangeState(bool state)
    {
        controller.enabled = state;
        for (int i = 0; i < enemys.Length; i++)
        {
            enemys[i].enabled = state;
        }
    }
}
