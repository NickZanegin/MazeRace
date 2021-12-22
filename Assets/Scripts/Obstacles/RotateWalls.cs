using UnityEngine;

public class RotateWalls : MonoBehaviour
{
    Vector3 rotor = Vector3.up;
    int speed = 78;
    private void Update()
    {
        transform.eulerAngles += rotor * speed * Time.deltaTime;
    }
}
