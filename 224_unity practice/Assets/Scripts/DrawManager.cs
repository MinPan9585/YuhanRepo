using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawManager : MonoBehaviour
{
    public static DrawManager dm;
    private void Awake()
    {
        dm = this;
    }

    [SerializeField] private Line linePrefab;
    public const float RESOLUTION = 0.1f;
    private Line currentLine;
    public Transform playerTrans;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(currentLine != null)
                currentLine.SetPosition(playerTrans.position);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            currentLine = null;
        }
    }
}
