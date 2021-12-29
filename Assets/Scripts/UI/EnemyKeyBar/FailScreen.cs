using UnityEngine;

public class FailScreen : MonoBehaviour
{
    [SerializeField] Finish finish;
    void Start()
    {
        finish.eventFaill += UnActive;
    }
    private void UnActive()
    {
        finish.eventFaill -= UnActive;
        gameObject.SetActive(false);
    }
}
