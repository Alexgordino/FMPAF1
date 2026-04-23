using TMPro;
using UnityEngine;

public class eattack : MonoBehaviour
{

    public Transform playa;
    public Transform enemy;
    public GameObject attack;
    public Vector2 target;
    public float speed = 8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       GameObject bullet = Instantiate(attack, enemy.position, enemy.rotation);
        transform.position = Vector2.MoveTowards(gameObject.transform.position, playa.position, speed * Time.deltaTime);
     
    }
}
