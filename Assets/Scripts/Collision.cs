using UnityEngine;

public class Collision : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collision detected with Player");
        }
    }
}
