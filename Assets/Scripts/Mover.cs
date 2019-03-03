using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float mass = 1f;
    public Vector3 velocity;
    public Vector3 acceleration;
    public float maxVelocity = 10f;

    void FixedUpdate()
    {
        velocity += acceleration * Time.fixedDeltaTime;
        transform.position += velocity * Time.fixedDeltaTime;

        // if (velocity.magnitude > maxVelocity)
        //     velocity = velocity * (maxVelocity / velocity.magnitude);
    }

    public void ApplyForce(Vector3 force)
    {
        acceleration += force / mass;
    }
}
