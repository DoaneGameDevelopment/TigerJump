using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour
{
    public float moveDistance = 0f;  // how far up to move
    public float speed = 0f;         // movement speed
    public float pauseTime = 0f;     // how long to pause at top/bottom

    private Vector3 startPos;
    private Vector3 topPos;
    private bool movingUp = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        topPos = startPos + new Vector3(0, moveDistance, 0);
        StartCoroutine(MovePlatform());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MovePlatform()
    {
        while (true)
        {
            Vector3 target = movingUp ? topPos : startPos;

            // Move until close to the target
            while (Vector3.Distance(transform.position, target) > 0.00f)
            {
                transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
                yield return null;
            }

            // Snap to target and pause
            transform.position = target;
            yield return new WaitForSeconds(pauseTime);

            // Reverse direction
            movingUp = !movingUp;
        }
    }
}
