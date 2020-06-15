using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Experimental.TerrainAPI;

[CustomEditor(typeof(Rotate))]
public class RotateEditor : Editor
{
    public Rotate m_rotate;
    private void OnEnable()
    {
        m_rotate = (Rotate)target;
    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Rotate to Point"))
        {
            m_rotate.RotatePoint();
        }
    }
}
