using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    [SerializeField] int index; 
    public void NextLvl()
    {
        SceneManager.LoadScene(index);
    }
}
