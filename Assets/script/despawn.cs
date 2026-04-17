using UnityEngine;


public class despawn : MonoBehaviour
{
    float timer = 0.5f;
   
    void Update()
    {
       timer -= Time.deltaTime;
       
        if (timer <= 0)
        {
            Destroy(gameObject);
           
        }
    }
}
