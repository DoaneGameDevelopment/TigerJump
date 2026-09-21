using UnityEngine;

public class BlackholeCollision : MonoBehaviour
{
    public void onCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collision detected with Player");
        }
    }
}
