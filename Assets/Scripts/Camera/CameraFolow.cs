using UnityEngine;

public class CameraFolow : MonoBehaviour
{
    [SerializeField] Transform player;
    void Update()
    {
        transform.localPosition = new Vector3(player.position.x, transform.position.y, player.position.z - 5.138f);
    }
}
