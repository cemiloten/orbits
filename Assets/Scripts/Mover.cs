using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float mass = 1f;
    public float velocityDrag = 1f;
    public float accelerationDrag = 0.90f;
    public float maxVelocity = 10f;
    public Vector3 velocity;
    public Vector3 acceleration;

    void FixedUpdate()
    {
        velocity += acceleration * Time.fixedDeltaTime;
        transform.position += velocity * Time.fixedDeltaTime;

        velocity = velocity.magnitude < 0.01f ? Vector3.zero : velocity * velocityDrag;
        acceleration = acceleration.magnitude < 0.01f ? Vector3.zero : acceleration * accelerationDrag;

        if (velocity.magnitude > maxVelocity)
            velocity = velocity * (maxVelocity / velocity.magnitude);
    }

    public void ApplyForce(Vector3 force)
    {
        acceleration += force / mass;
    }
}
