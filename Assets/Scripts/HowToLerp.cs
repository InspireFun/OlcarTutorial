using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToLerp : MonoBehaviour
{
    public Vector3 destination;
    public float speed = 1f;
    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, (destination- transform.position).normalized, Time.deltaTime*speed);
    }

    
}
