using UnityEngine;

public class combat : MonoBehaviour
{
    public float timer = 0.5f;
    public bool running = false;
    public Transform attack;
    public GameObject cube;
    public Rigidbody2D rb2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(cube, attack.position, attack.rotation);

        }
    }
}
