using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformReverse : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float speed;
    public Vector3 direction = new Vector3(0.03f, 0, 0);

    void Update()
    {
        //transform.position += direction * speed * Time.deltaTime;
        transform.position += direction;

        if (transform.position.x >= endPosition.x)
        {
            direction = new Vector3(-0.03f, 0, 0);
        }
        else if (transform.position.x <= startPosition.x)
        {
            direction = new Vector3(0.03f, 0, 0);
        }
    }
}
