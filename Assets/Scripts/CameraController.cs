using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public new Camera camera;

    private Vector3 relativePosition;

    void Awake()
    {
    }

    void Start()
    {
        relativePosition = camera.transform.position - transform.position;
    }

    void Update()
    {
        camera.transform.position = transform.position + relativePosition;
    }
}