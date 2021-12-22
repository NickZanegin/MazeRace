using UnityEngine;

public class AddKey : MonoBehaviour
{
    [SerializeField] GameObject key;
    [SerializeField] Material green;
    [SerializeField] ParticleSystem effect;
    public void FinishLvl()
    {
        Add();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<RaisedCoins>() && other.GetComponent<RaisedCoins>().keys > 0) 
        {
            Add();
            other.GetComponent<RaisedCoins>().keys--;
        }
    }
    private void Add()
    {
        key.SetActive(true);
        effect.transform.position = transform.position;
        GetComponent<MeshRenderer>().material = green;
        effect.Play();
    }
}
