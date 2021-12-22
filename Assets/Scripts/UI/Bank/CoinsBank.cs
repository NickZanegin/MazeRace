using UnityEngine;
using TMPro;

public class CoinsBank : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    public static CoinsBank coins;
    private int coin = 0;
    private void Start()
    {
        coins = this;
        if (PlayerPrefs.HasKey("Coins"))
        {
            coin = PlayerPrefs.GetInt("Coins");
        }
        UpdateText();
    }
    public static void AddCoin() => coins.CoinsAdd();
    public void CoinsAdd()
    {
        coin++;
        UpdateText();
        PlayerPrefs.SetInt("Coins", coin);
    }
    private void UpdateText()
    {
        text.text = coin.ToString();
    }
}
