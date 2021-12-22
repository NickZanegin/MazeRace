using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLvl : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
