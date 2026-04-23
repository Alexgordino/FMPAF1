using UnityEngine;
using UnityEngine.InputSystem;

public class TravelTowards : MonoBehaviour
{
    public Vector2 targetPosition;
    float speed = 8f;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(gameObject.transform.position, targetPosition, speed * Time.deltaTime);
        if (targetPosition == new Vector2(gameObject.transform.position.x, gameObject.transform.position.y))
        {
            Destroy(gameObject);
            
        }
    }
}
