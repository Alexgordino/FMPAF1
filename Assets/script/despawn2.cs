using UnityEngine;

public class despawn2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        Destroy(gameObject);

           
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
