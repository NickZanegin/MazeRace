using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Joystick controller;
    [SerializeField] Animator animator;
    [SerializeField] float speed;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(controller.Horizontal * speed, rb.velocity.y, controller.Vertical * speed);
        if (controller.Horizontal != 0 | controller.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }
    }
    public void Winn()
    {
        this.enabled = false;
    }
    public void Faill()
    {
        this.enabled = false;
        animator.SetBool("Faill", true);
    }
}
