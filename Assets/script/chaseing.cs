using Unity.VisualScripting;
using UnityEngine;

public class chaseing : MonoBehaviour
{
        [Header("Target Settings")]
        public Transform player;       
        public float chaseSpeed = 5f;  
        public float chaseRange = 10f; 

        void Update()
        {
            float distance = Vector3.Distance(transform.position, player.position);


            if (distance <= chaseRange)
            {

               
                transform.position = Vector3.MoveTowards(
                    transform.position,
                    player.position,
                    chaseSpeed * Time.deltaTime
                );
            }
        }
    }
