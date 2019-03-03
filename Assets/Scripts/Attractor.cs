using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    public readonly static float G = 1f;

    public float mass;

    private static Mover[] movers;

    private void Start()
    {
        movers = FindObjectsOfType<Mover>();
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < movers.Length; ++i)
        {
            Attract(movers[i]);
        }
    }

    public void Attract(Mover mover)
    {
        if (mover == this)
            return;

        Vector3 direction = transform.position - mover.transform.position;
        float distance = direction.magnitude;

        distance = Mathf.Clamp(
            distance,
            GameManager.Instance.minAttractionDistance,
            GameManager.Instance.maxAttractionDistance);


        float forceMagnitude = (mass * mover.mass) / Mathf.Pow(distance, 2f) * G;
        Vector3 force = direction.normalized * forceMagnitude;
        mover.ApplyForce(force);
    }
}