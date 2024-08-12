using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBtn : MonoBehaviour
{
    public GameObject mainCanvas;
    public void StartGame()
    {
        mainCanvas.SetActive(false);
    }
}
