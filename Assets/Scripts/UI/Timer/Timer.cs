using System;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] RestartState restart;
    float time = 0;
    private void Start()
    {
        restart.eventRestart += Restart;
    }
    void Update()
    {
        time +=  Time.deltaTime;
        text.text = Math.Round(time,2).ToString();
    }
    public void StopTimer()
    {
        this.enabled = false;
    }
    public void Restart()
    {
        time = 0;
        text.text = "00.00";
    }
}
