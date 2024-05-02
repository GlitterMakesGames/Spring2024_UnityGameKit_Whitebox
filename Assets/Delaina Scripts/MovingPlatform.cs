using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float speed = 3f;
    public Vector3 direction = new Vector3(-1, 0, 0);

    private float timer = 0f;

    void Update()
    {
        /*if (timer < 3f)
        {
            timer += Time.deltaTime;
        }
        else
        {
            transform.position += direction;

            if (transform.position.x <= endPosition.x)
            {
                direction = new Vector3(0.03f, 0, 0);
            }
            else if (transform.position.x >= startPosition.x)
            {
                direction = new Vector3(-0.03f, 0, 0);
            }
        }*/
        transform.position += direction * speed * Time.deltaTime;

        if (transform.position.x <= endPosition.x)
        {
            direction = new Vector3(1, 0, 0);
        }
        else if (transform.position.x >= startPosition.x)
        {
            direction = new Vector3(-1, 0, 0);
        }
    }
}