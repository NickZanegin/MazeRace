using UnityEngine;

public class Roof : MonoBehaviour
{
    [SerializeField] MeshRenderer mesh;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            mesh.enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            mesh.enabled = true;
        }
    }
}
