using UnityEngine.SceneManagement;
using UnityEngine;

public class Load : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefs.HasKey("scenes"))
        {
            var lvl = PlayerPrefs.GetInt("scenes");
            SceneManager.LoadScene(lvl);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }
}
