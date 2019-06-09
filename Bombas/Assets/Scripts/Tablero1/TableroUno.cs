using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableroUno : MonoBehaviour
{
   
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 50, 30), "Reset"))
                
            Application.LoadLevel(Application.loadedLevel);
        
    }
}
