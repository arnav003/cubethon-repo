using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;// a reference to  our player movement script

    
    private void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }


    }


}
