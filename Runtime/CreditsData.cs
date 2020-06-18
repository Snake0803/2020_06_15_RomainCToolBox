using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Student", menuName = "Custom/Student", order = 0)]
public class CreditsData : ScriptableObject
{

    public string m_studentName;
    public string m_studentFirstName;
    [SerializeField]
    public enum m_studentJob
    {
        artist,
        developper
    };

    public m_studentJob studentJob;

    public string m_Surname;
}
