using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Mover
{
    public new Camera camera;
    public float speed = 2f;
    public float fuel = 100f;

    private Vector3 start = Vector3.zero;
    private Vector3 end = Vector3.zero;
    private GUIStyle style = new GUIStyle();

    private void OnEnable()
    {
        TouchManager.OnTouchStart += OnTouchStart;
        TouchManager.OnTouchHold += OnTouchHold;
        TouchManager.OnTouchMove += OnTouchMove;
        TouchManager.OnTouchEnd += OnTouchEnd;
    }

    private void OnDisable()
    {
        TouchManager.OnTouchStart -= OnTouchStart;
        TouchManager.OnTouchHold -= OnTouchHold;
        TouchManager.OnTouchMove -= OnTouchMove;
        TouchManager.OnTouchEnd -= OnTouchEnd;
    }

    private void Start()
    {
        style.fontSize = 24;
        style.normal.textColor = Color.white;
    }

    private void Update()
    {
        camera.transform.position = new Vector3(transform.position.x, 10f, transform.position.z);
        if (velocity.magnitude > 0.01f)
            transform.rotation = Quaternion.LookRotation(velocity);

#if UNITY_EDITOR

        if (Input.GetMouseButtonDown(0))
        {
            start = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            start.y = 0f;
        }

        if (Input.GetMouseButtonUp(0))
        {
            end = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            end.y = 0f;
            Move(start - end);
            Debug.DrawLine(start, end, Color.red, 2f);
        }
#endif

        Debug.DrawLine(transform.position, transform.position + velocity);
    }

    private void OnTouchStart(TouchInfo touchInfo) {}

    private void OnTouchHold(TouchInfo touchInfo) {}

    private void OnTouchMove(TouchInfo touchInfo) {}

    private void OnTouchEnd(TouchInfo touchInfo)
    {
        Vector3 start = Camera.main.ScreenToWorldPoint(touchInfo.StartPosition);
        Vector3 end = Camera.main.ScreenToWorldPoint(touchInfo.Position);
        start.y = 0f;
        end.y = 0f;
        Move(start - end);
        Debug.DrawLine(start, end, Color.red, 2f);
    }

    private void Move(Vector3 direction)
    {
        acceleration += direction * speed;
        fuel -= direction.magnitude;
    }

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(20, 20, 800, 200));
        GUILayout.Label(string.Format("Velocity: {0:0.##}", velocity.magnitude), style);
        GUILayout.Label(string.Format("Acceleration: {0:0.##}", acceleration.magnitude), style);
        GUILayout.Label(string.Format("Fuel: {0:0.##}", fuel), style);
        GUILayout.EndArea();
    }
}
