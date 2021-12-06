using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLvl : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
