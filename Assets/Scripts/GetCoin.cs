using UnityEngine;

public class GetCoin : MonoBehaviour
{
    [SerializeField] ParticleSystem upCoin;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Player>())
        {
            CoinsBank.AddCoin();
            upCoin.transform.position = transform.position;
            upCoin.Play();
            gameObject.SetActive(false);
        }
    }
}
