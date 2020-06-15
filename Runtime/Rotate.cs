using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    Transform m_point;
    [SerializeField]
    Vector3 m_axis;

    [SerializeField]
    float m_angle;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(m_point.position, m_axis, m_angle);
    }
}
