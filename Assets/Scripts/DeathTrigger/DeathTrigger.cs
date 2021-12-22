using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Dead>() || other.GetComponent<Enemys.Dead>())
        {
            other.GetComponent<IMortal>().Restart();
        }
    }
}
