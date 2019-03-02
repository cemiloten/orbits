using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

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
    }

    private void OnTouchStart(TouchInfo touchInfo)
    {
    }

    private void OnTouchHold(TouchInfo touchInfo)
    {
    }

    private void OnTouchMove(TouchInfo touchInfo)
    {
    }

    private void OnTouchEnd(TouchInfo touchInfo)
    {
        Vector3 start = Camera.main.ScreenToWorldPoint(touchInfo.StartPosition);
        Vector3 end = Camera.main.ScreenToWorldPoint(touchInfo.Position);
        start.z = 0f;
        end.z = 0f;
        Debug.DrawLine(start, end, Color.red, 5f);
    }

}
