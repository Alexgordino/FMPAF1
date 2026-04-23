using Unity.VisualScripting;
using UnityEngine;

public class enemy : MonoBehaviour
{
 
    public int health = 3;
    
   
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("attack"))
            health -= 1;
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("rangeattack"))
            health -= 1; 
    }
    private void Update()
    {
        if (health == 0)
            Destroy(gameObject);

    }

}
