using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    public GameObject sunPrefab;
    public GameObject planetPrefab;
    public Vector3 center;

    private GameObject sun;
    private GameObject planet;
    private float angle = 0f;

    private void Start()
    {
        sun = Instantiate(sunPrefab, Vector3.zero, Quaternion.identity);
        planet = Instantiate(planetPrefab, new Vector3(2f, 2f, 0f), Quaternion.identity);
    }

    private void Update()
    {
        angle += Time.deltaTime;
        float range = 2f;
        planet.transform.position = new Vector3(range * Mathf.Cos(angle), range * Mathf.Sin(angle), 0f);
    }
}
