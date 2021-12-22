using UnityEngine;
using UnityEngine.UI;

public class HideStart : MonoBehaviour
{
    [SerializeField] Button start;
    private void Start()
    {
        if (PlayerPrefs.HasKey("ferstLvl"))
        {
            start.onClick.Invoke();
        }
    }
    public void tapStart()
    {
        if (!PlayerPrefs.HasKey("ferstLvl"))
        {
            PlayerPrefs.SetInt("ferstLvl", 1);
        }
    }
}
