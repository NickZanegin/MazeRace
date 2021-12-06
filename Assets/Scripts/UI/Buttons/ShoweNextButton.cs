using UnityEngine;

public class ShoweNextButton : MonoBehaviour
{
    [SerializeField] private GameObject nextButton;
    [SerializeField] Finish finish;
    private void Start()
    {
        finish.eventWinn += ShoweButton;
    }
    private void ShoweButton()
    {
        nextButton.SetActive(true);
    }
    private void HideButton()
    {
        nextButton.SetActive(false);
    }
}
