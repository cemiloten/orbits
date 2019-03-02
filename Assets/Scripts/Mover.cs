using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float mass;
    public Vector3 velocity;
    public Vector3 acceleration;

    void FixedUpdate()
    {
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
    }

    public void ApplyForce(Vector3 force)
    {
        acceleration += force / mass;
    }
}
