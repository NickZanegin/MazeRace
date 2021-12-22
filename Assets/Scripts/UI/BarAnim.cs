using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Ui
{
    public class BarAnim : MonoBehaviour
    {
        [SerializeField] Image progress;
        [SerializeField] TextMeshProUGUI left;
        [SerializeField] TextMeshProUGUI center;
        [SerializeField] TextMeshProUGUI right;
        [SerializeField] SaveDataObject saveData;
        [SerializeField] ProgressBar bar;
        public int lvl;
        Color green;
        
        private void Awake()
        {
            var proc = 1 / 255f;
            green = new Color(proc * 127f, proc * 221f, proc * 70f);
        }
        private void Start()
        {
            if (saveData.curentlvl != lvl)
            {
                bar.LoadProgress();
            }
            if (saveData.StartGame)
            {
                saveData.StartGame = false;
                bar.LoadProgress();
            }
            else
            {
                UpdateProgress();
            }
        }
        public void UpdateProgress()
        {
            if (saveData.curentlvl != lvl)
            {
                saveData.curentlvl = lvl;
                NextLvl();
                progress.fillAmount = saveData.acmount;
            }
            else
            {
                Restart();
                progress.fillAmount = saveData.acmount;
            }
        }
        private void NextLvl()
        {
            switch (saveData.acmount)
            {
                case 0.159f:
                    left.color = Color.white;
                    center.color = Color.white;
                    right.color = green;
                    saveData.acmount = 0.58f;
                    break;
                case 0.58f:
                    left.color = Color.white;
                    center.color = Color.white;
                    right.color = Color.white;
                    saveData.acmount = 1;
                    break;
                case 1:
                    left.color = Color.white;
                    center.color = green;
                    right.color = green;
                    saveData.acmount = 0.159f;
                    break;
            }
        }
        private void Restart()
        {
            switch (saveData.acmount)
            {
                case 0.159f:
                    left.color = Color.white;
                    center.color = green;
                    right.color = green;
                    break;
                case 0.58f:
                    left.color = Color.white;
                    center.color = Color.white;
                    right.color = green;
                    break;
                case 1:
                    left.color = Color.white;
                    center.color = Color.white;
                    right.color = Color.white;
                    break;
            }
        }
    }
}
