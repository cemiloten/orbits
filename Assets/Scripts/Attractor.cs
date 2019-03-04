using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    public float mass;
    public float minDistance = 5f;
    public float maxDistance = 10f;
    public float attractionRadius;

    private static Mover[] movers;

    private void Start()
    {
        movers = FindObjectsOfType<Mover>();
    }

    private void Update()
    {
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < movers.Length; ++i)
        {
            if (Vector3.Distance(transform.position, movers[i].transform.position) < attractionRadius)
                Attract(movers[i]);
        }
    }

    public void Attract(Mover mover)
    {
        if (mover == this)
            return;

        Vector3 direction = transform.position - mover.transform.position;
        float distance = direction.magnitude;
        distance = Mathf.Clamp(distance, minDistance, maxDistance);

        float forceMagnitude = (mass * mover.mass) / Mathf.Pow(distance, 2f);
        Vector3 force = direction.normalized * forceMagnitude;
        mover.ApplyForce(force);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.2f);
        Gizmos.DrawSphere(transform.position, attractionRadius);
    }
}