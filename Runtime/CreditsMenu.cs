using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsMenu : MonoBehaviour
{
    [SerializeField]
    [Tooltip("List of students working on the project")]
    List<CreditsData> m_ListStudent = new List<CreditsData>();

    [SerializeField]
    [Tooltip("List of Text in the current canvas")]
    List<Text> m_ListTextStudent;

    private void Start()
    {
        for (int i = 0; i < m_ListStudent.Count; i++)
        {
            m_ListTextStudent[i].text = m_ListStudent[i].m_studentFirstName + " " + m_ListStudent[i].m_studentName + "\n" + m_ListStudent[i].studentJob.ToString();
            if(m_ListStudent[i].studentJob == CreditsData.m_studentJob.Developer)
            {
                m_ListTextStudent[i].color = Color.blue;
            }
            else
            {
                m_ListTextStudent[i].color = Color.green;
            }
        }
        
    }
}
