using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class ranged : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject Projectile ;
    public Transform PlayerTransform;
    public Rigidbody2D rb;
    public Vector3 mouse;
    public Vector2 range1;
    public float time;
    public bool cool = false;
    public float timer = 1f;


    // Update is called once per frame
    void Update()
    {
        if (cool == true)
        {
            timer -= Time.deltaTime;
            if (timer < 0f)
            {
                cool = false;
                timer = 1f;
            }
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            if (cool == false)
            {
                mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                GameObject bullet = Instantiate(Projectile, PlayerTransform.position, PlayerTransform.rotation);
                //GameObject bullet = Instantiate(Projectile, new Vector3(0f, 0f, 0f), PlayerTransform.rotation);

                bullet.GetComponent<PlayerShoot>().targetPosition.position = mouse;
                cool = true;
               
                
            }
        }

    }
}
