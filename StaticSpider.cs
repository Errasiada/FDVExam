using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticSpider : MonoBehaviour
{
    public Vector3 goal;
    public Vector3 target;
    public float speed;
    private bool point;

    private void Update()
    {
        if (point == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
        else 
        {
            transform.position = Vector3.MoveTowards(transform.position, goal, speed * Time.deltaTime);
        }

        if (transform.position == target)
        {
            point = false;
        }
        else if (transform.position == goal)
        {
            point = true;
        }
    }
}
