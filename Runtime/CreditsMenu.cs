using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsMenu : MonoBehaviour
{

    public Color m_programmerColor=new Color(255,100,100) ;
    public Color m_artistColor= new Color(100, 255, 100);
    public Color m_coachColor = new Color(100, 100, 255);

    [SerializeField]
    [Tooltip("List of students working on the project")]
    List<CreditsData> m_ListStudent = new List<CreditsData>();

    [SerializeField]
    [Tooltip("List of Text in the current canvas")]
    List<Text> m_ListTextStudent;

    [SerializeField]
    [Tooltip("List of Image in the current canvas")]
    List<Image> m_ListImageProfile;


    int lastIndex;
    public bool m_loadPageAtStart=true;


    private void Start()
    {
        if (m_loadPageAtStart)
            ShowNextPage();
    }



    [ContextMenu("Next Page")]
    public void ShowNextPage()
    {
        List<CreditsData> currentlistStudent = new List<CreditsData>();
        // Check if the number of student to display is less than the number to display in the canvas
        if(lastIndex + m_ListTextStudent.Count > m_ListStudent.Count)
        {
            for (int i = lastIndex; i < m_ListStudent.Count; i++)
            {
                currentlistStudent.Add(m_ListStudent[i]);

            }
            for (int i = 0; i < (m_ListTextStudent.Count-(m_ListStudent.Count-lastIndex)); i++)
            {
                currentlistStudent.Add(m_ListStudent[i]);
            }
            lastIndex = m_ListTextStudent.Count - (m_ListStudent.Count - lastIndex);
        }
        else
        {
            for (int i = lastIndex; i < lastIndex + m_ListTextStudent.Count; i++)
            {
                currentlistStudent.Add(m_ListStudent[i]);
                
            }
            
            lastIndex = lastIndex + m_ListTextStudent.Count;
        }
        ShowStudent(currentlistStudent);
    }

    // Show all the information of all students
    void ShowStudent(List<CreditsData> listStudent)
    {
        for (int i = 0; i < m_ListTextStudent.Count; i++)
        {
            m_ListTextStudent[i].text = listStudent[i].m_Surname + "\n" + listStudent[i].m_studentFirstName + " " + listStudent[i].m_studentName + "\n" + listStudent[i].studentJob.ToString();
            m_ListImageProfile[i].sprite = listStudent[i].m_profilePicture;
            if (listStudent[i].studentJob == CreditsData.m_studentJob.Developer)
            {
                m_ListTextStudent[i].color = m_programmerColor;
            }
            else if(listStudent[i].studentJob == CreditsData.m_studentJob.Artist)
            {
                m_ListTextStudent[i].color = m_artistColor;
            }
            else
            {
                m_ListTextStudent[i].color = m_coachColor;
            }
        }

    }


}
