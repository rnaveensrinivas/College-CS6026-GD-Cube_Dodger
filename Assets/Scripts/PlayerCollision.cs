using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement; 

    private bool collided = false; 

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<PlayerMovement>().enabled = false;

            FindObjectOfType<AudioManager>().Stop("Theme");
            
            if( collided == false)
            {
                FindObjectOfType<AudioManager>().Play("ObstacleCollision");
                collided = true;
            }

            FindObjectOfType<gameManager>().EndGame();
        }
    }
}
