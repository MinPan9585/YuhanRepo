using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{
    public Transform player;
    public float x1;
    public float x2;
    public float y2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var playerX = player.position.x;
        if (playerX < x1)
        {
            transform.position = new Vector3(Mathf.Max(playerX,0), 0, -10);
        }
        else if (playerX < x2)
        {
            transform.position = new Vector3(playerX, (playerX - x1) * y2 / (x2 - x1),-10);
        }
        else
        {
            transform.position = new Vector3(playerX, y2, -10);
        }
    }
    
}
