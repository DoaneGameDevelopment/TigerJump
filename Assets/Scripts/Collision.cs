using UnityEngine;

public class Collision : MonoBehaviour
{
    public void onCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collision detected with Player");
        }
    }
}
