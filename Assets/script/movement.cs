using UnityEngine;

public class movement : MonoBehaviour
{
    public float movespeed = 5f;
    public Rigidbody2D rb;
    Vector2 movements;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        movements.x = Input.GetAxis("Horizontal");
        movements.y = Input.GetAxis("Vertical");
        rb.linearVelocity = movements * movespeed;
    }
}
