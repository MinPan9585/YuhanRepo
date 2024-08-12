using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExitBtn : MonoBehaviour
{
    public void ExitGame()
    {
        EditorApplication.ExitPlaymode();
        //Application.Quit();
    }
}
