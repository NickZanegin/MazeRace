using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    Vector3 rotor = Vector3.forward;
    int speed = 150;
    private void Update()
    {
        transform.eulerAngles += rotor * speed * Time.deltaTime;
    }
}
