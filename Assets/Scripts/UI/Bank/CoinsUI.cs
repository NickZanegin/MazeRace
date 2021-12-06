using UnityEngine;
using UnityEngine.UI;

public class CoinsUI : MonoBehaviour
{
    [SerializeField] Bank bank;
    [SerializeField] Image[] keys;
    [SerializeField] GameObject text;
    [SerializeField] RestartState restart;
    int index = 0;
    void Start()
    {
        bank.eventBankUpdate += UpdateUI;
        restart.eventRestart += Restart;
    }
    private void UpdateUI()
    {
        keys[index].color = new Color(255, 202, 0, 255);
        index++;
        if(index == 3)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                keys[i].gameObject.SetActive(false);
            }
            text.SetActive(true);
        }
    }
    private void Restart()
    {
        index = 0;
        for (int i = 0; i < keys.Length; i++)
        {
            keys[i].gameObject.SetActive(true);
        }
        text.SetActive(false);
    }

}
