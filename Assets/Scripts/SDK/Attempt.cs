using UnityEngine;

[CreateAssetMenu(fileName = "AttemptScore") ]
public class Attempt : ScriptableObject
{
    public int attemptNumber = 1;
    public int GetAttempt()
    {
        return attemptNumber;
    }
    public void AddAttempt()
    {
        attemptNumber++;
    }
    public void RemoveAttempt()
    {
        attemptNumber = 1;
    }
}
