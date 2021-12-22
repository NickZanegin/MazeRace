using UnityEngine;

public class DeliteAllKey : MonoBehaviour
{
   public void Dell()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.DeleteKey("curentlvl");
    }
}
