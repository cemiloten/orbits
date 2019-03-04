using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : Mover
{
    public float velocityRange = 5f;

    private void Start()
    {
        velocity = new Vector3(Random.Range(-velocityRange, velocityRange), 0f, Random.Range(-velocityRange, velocityRange));
    }
}
