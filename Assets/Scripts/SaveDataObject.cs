using UnityEngine;

[CreateAssetMenu(fileName = "SaveData") ]
public class SaveDataObject : ScriptableObject
{
    public float acmount = 0.159f;
    public int curentlvl = -1;
    public int barCount = 1;
    public int barLvltoUpdate = 3;
    public bool StartGame = true;
}
