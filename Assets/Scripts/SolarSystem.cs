using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    public GameObject sunPrefab;
    public GameObject planetPrefab;
    public Vector3 center;

    private GameObject sun;
    private GameObject[] planets;
    private float angle = 0f;


    private void Start()
    {
        // sun = Instantiate(sunPrefab, Vector3.zero, Quaternion.identity);
        // planets = new GameObject[1];
        // planets[0] = Instantiate(planetPrefab, new Vector3(1f, 0f, 0f), Quaternion.identity);
    }

    private void FixedUpdate()
    {
        // for (int i = 0; i < attractors.Length; ++i)
        // {
        //     Mover attr = attractors[i];
        //     for (int j = 0; j < attractors.Length; ++j)
        //     {
        //         attr.Attract(attractors[j]);
        //     }
        // }
    }

    private void Update()
    {
        // angle += Time.deltaTime;
        // float range = 2f;
        // planets[0].transform.position = new Vector3(range / 2f * Mathf.Cos(angle), range * Mathf.Sin(angle), 0f);
    }
}
