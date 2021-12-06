using UnityEngine;

public class AddKey : MonoBehaviour
{
    [SerializeField] GameObject key;
    [SerializeField] Material green;
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
        GetComponent<MeshRenderer>().material = green;
    }
}
