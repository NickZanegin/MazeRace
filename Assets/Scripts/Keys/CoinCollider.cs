using UnityEngine;

public class CoinCollider : MonoBehaviour
{
    [SerializeField] ParticleSystem upParticle;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Player>())
        {
            other.gameObject.GetComponent<RaisedCoins>().PickUp();
            upParticle.transform.position = transform.position;
            upParticle.Play();
            gameObject.SetActive(false);
        } 
    }
}
