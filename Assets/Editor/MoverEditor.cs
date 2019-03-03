using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(Mover))]
public class MoverEditor : Editor
{
    void OnSceneGUI()
    {
        Mover mover = target as Mover;
        Gizmos.color = Color.red;
        Debug.DrawLine(mover.transform.position, mover.transform.position + mover.velocity);
    }
}
