using UnityEngine;
using TMPro;

namespace Ui
{
    public class ProgressBar : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI pastlvl;
        [SerializeField] TextMeshProUGUI centerlvl;
        [SerializeField] TextMeshProUGUI nextlvl;
        [SerializeField] SaveDataObject saveData;
        int curentLvl;
        public void LoadProgress()
        {
            if (PlayerPrefs.HasKey("curentlvl"))
            {
                saveData.barCount = PlayerPrefs.GetInt("curentlvl");
            }
            if (saveData.barLvltoUpdate == 0)
            {
                saveData.barCount++;
                curentLvl = saveData.barCount;
                saveData.barLvltoUpdate = 3;
            }
            else if (saveData.barLvltoUpdate == 1)
            {
                saveData.barCount++;
                curentLvl = saveData.barCount;
                curentLvl -= 2;
            }
            else if (saveData.barLvltoUpdate == 2)
            {
                saveData.barCount++;
                curentLvl = saveData.barCount;
                curentLvl -= 1;
            }
            else
            {
                curentLvl = saveData.barCount;
            }
            saveData.barLvltoUpdate--;
            UpdateBar();
            PlayerPrefs.SetInt("curentlvl", saveData.barCount);
        }
        public void UpdateBar()
        {
            pastlvl.text = $"{curentLvl}";
            centerlvl.text = $"{curentLvl + 1}";
            nextlvl.text = $"{curentLvl + 2}";
        }
        private void OnApplicationQuit()
        {
            if(saveData.barLvltoUpdate == 1)
            {
                saveData.barCount += 1;
            }
            else if(saveData.barLvltoUpdate == 0)
            {
                saveData.barCount += 2;
            }
            //PlayerPrefs.SetInt("curentlvl", saveData.barCount);
        }
    }
}
