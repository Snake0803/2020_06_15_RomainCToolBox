using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RotatePoint))]
public class Rotate_Editor : Editor
{
    public RotatePoint m_rotate;
    private void OnEnable()
    {
        m_rotate = (RotatePoint)target;
    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Rotate to Point"))
        {
            m_rotate.RotateToPoint();
        }
    }
}
