using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class eattack : MonoBehaviour
{

    public Transform playa;
    public Transform enemy;
    public GameObject attack;
    public Vector2 target;
    public float speed = 8f;
    public float timer = 1f;
    public bool cool = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
            if (cool == false)
            {
                GameObject bullets = Instantiate(attack, enemy.position, enemy.rotation);
                transform.position = Vector2.MoveTowards(gameObject.transform.position, playa.position, speed * Time.deltaTime);

            bullets.GetComponent<TravelTowards>().targetPosition = playa.position;
            
                
                cool = true;
                
                
                     
                
            }
            if (cool == true)
            {
                timer -= Time.deltaTime;
                if (timer < 0f)
                {
                    cool = false;
                    timer = 1f;
                }
            }
    }
}
