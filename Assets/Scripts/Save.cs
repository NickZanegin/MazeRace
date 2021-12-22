using UnityEngine;

public class Save : MonoBehaviour
{
    [SerializeField] int lvl = 0;
    private void Start()
    {
        PlayerPrefs.SetInt("scenes", lvl);
    }
}
