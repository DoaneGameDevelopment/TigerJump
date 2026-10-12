using UnityEngine;

public class Death_Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D deathCollision)
    {
        Debug.Log("collision occured");
        if (deathCollision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player has died");
            // Add logic for player death here
        }
    }
}
