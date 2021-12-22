using UnityEngine;
using UnityEngine.UI;

public class CoinsUI : MonoBehaviour
{
    [SerializeField] Bank bank;
    [SerializeField] Sprite haveKey;
    [SerializeField] Sprite winnKey;
    [SerializeField] Image[] keys;
    [SerializeField] Image[] keysFail;
    int index = 0;
    void Start()
    {
        bank.eventBankUpdate += UpdateUI;
    }
    private void UpdateUI()
    {
        keys[index].sprite = haveKey;
        keysFail[index].sprite = winnKey;
        index++;
    }
}
