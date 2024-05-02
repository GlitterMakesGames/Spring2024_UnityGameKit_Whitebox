using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformZ : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float speed;
    public Vector3 direction = new Vector3(0, 0, 0.03f);

    void Update()
    {
        //transform.position += direction * speed * Time.deltaTime;
        transform.position += direction;

        // NOTE: To use positive numbers, divide by 100!
        if (transform.position.z >= endPosition.z)
        {
            direction = new Vector3(0, 0, -0.03f);
        }
        else if (transform.position.z <= startPosition.z)
        {
            direction = new Vector3(0, 0, 0.03f);
        }
    }
}