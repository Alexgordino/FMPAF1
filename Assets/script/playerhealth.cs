using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerhealth : MonoBehaviour
{
    public int health = 5;
    public Text healthtext;

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("-1h"))
        {
            health -= 1;
            if (health == 0)
            {
                string currentscene = SceneManager.GetActiveScene().name;
               SceneManager.LoadScene(currentscene);
            }
        }
    }
    void Update()
    {
        healthtext.text = "health " + health;
    }
}
