using UnityEngine;

public class chests : MonoBehaviour
{
    public GameObject gain;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gain.GetComponent<playerhealth>().health += 3;
        Destroy(gameObject);
    }

}
