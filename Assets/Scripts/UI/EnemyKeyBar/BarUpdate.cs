using UnityEngine;
using UnityEngine.UI;

public class BarUpdate : MonoBehaviour
{
    [SerializeField] Sprite key;
    [SerializeField] Image[] bar;
    [SerializeField] MoveToPoints move;
    int keyIndex = 0;
    void Start()
    {
        move.eventNewKey += UpdateBar;
    }
    private void UpdateBar()
    {
        bar[keyIndex].sprite = key;
        keyIndex++;
    }
}
