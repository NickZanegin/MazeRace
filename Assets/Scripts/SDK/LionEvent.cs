using LionStudios.Suite.Analytics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LionEvent : MonoBehaviour
{
    int lvl;
    int attemptNum;
    [SerializeField] Attempt attmptScore;
    [SerializeField] Finish finish;
    private void Start()
    {
        lvl = SceneManager.GetActiveScene().buildIndex;
        attemptNum = attmptScore.GetAttempt();
        finish.eventWinn += LvlComplite;
        finish.eventFaill += Fail;
        LionAnalytics.LevelStart(lvl, attemptNum, null);
    }
    public void LvlComplite()
    {
        finish.eventWinn -= LvlComplite;
        LionAnalytics.LevelComplete(lvl, attemptNum, null, null);
        attmptScore.RemoveAttempt();
    }
    public void Fail()
    {
        finish.eventFaill -= Fail;
        LionAnalytics.LevelFail(lvl, attemptNum, null);
        attmptScore.AddAttempt();
    }
    public void Restart()
    {
        LionAnalytics.LevelRestart(this.lvl, attemptNum, null);
    }
}
