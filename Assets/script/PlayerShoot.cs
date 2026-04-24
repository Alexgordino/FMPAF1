using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public Transform targetPosition;
    Rigidbody2D rb;
    float speed = 20f;
    bool fire = false;

    private void Start()
    {
        gameObject.transform.LookAt(targetPosition);
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(fire==false)
        {
            rb.AddForce(transform.forward * speed, ForceMode2D.Impulse);
            fire = true;
        }
    }
}
