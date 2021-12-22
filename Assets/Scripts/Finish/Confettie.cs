using System.Collections;
using UnityEngine;

public class Confettie : MonoBehaviour
{
    [SerializeField] Finish finish;
    public ParticleSystem[] confetties;
    //public AudioSource confetiSound;
    private void Start()
    {
        finish.eventWinn += StartParticle;
    }
    public void StartParticle()
    {
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(0.4f);
        confetties[0].Play();
        confetties[1].Play();
            //confetiSound.Play();
        yield return new WaitForSecondsRealtime(0.4f);
        confetties[2].Play();
        confetties[3].Play();
        yield return new WaitForSecondsRealtime(0.4f);
        confetties[4].Play();
        confetties[5].Play();
        //confetiSound.Play();
        yield return new WaitForSecondsRealtime(0.4f);
        confetties[6].Play();
        confetties[7].Play();
    }
}
