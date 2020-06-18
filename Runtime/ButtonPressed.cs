using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonPressed : MonoBehaviour
{
    public UnityEvent showCanvas1;
    public UnityEvent showCanvas2;
    public UnityEvent showCanvas3;
    public UnityEvent hideAllCanvas;

    int buttonPressedCount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        ShowCanvas();
        Debug.Log(buttonPressedCount);
        buttonPressedCount += 1;
        if(buttonPressedCount > 3)
        {
            buttonPressedCount = 0;
        }
        
    }

    void ShowCanvas()
    {
        if(buttonPressedCount == 0)
        {
            hideAllCanvas.Invoke();
        }
        if(buttonPressedCount == 1)
        {
            showCanvas1.Invoke();
        }
        else if(buttonPressedCount == 2)
        {
            showCanvas2.Invoke();
        }
        else if(buttonPressedCount == 3)
        {
            showCanvas3.Invoke();
        }
    }
}
