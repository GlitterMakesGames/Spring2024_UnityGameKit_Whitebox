using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformXZ : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float speed;
    public Vector3 direction = new Vector3(0.03f, 0, -0.03f);

    void Update()
    {
        //transform.position += direction * speed * Time.deltaTime;
        transform.position += direction;

        // NOTE: To use positive numbers, divide by 100!
        if (transform.position.x >= -99.5f
            || transform.position.z <= -9)
        {
            direction = new Vector3(-0.03f, 0, 0.03f);
        }
        else if (transform.position.x <= -114
                 || transform.position.z >= 23)
        {
            direction = new Vector3(0.03f, 0, -0.03f);
        }
    }
}