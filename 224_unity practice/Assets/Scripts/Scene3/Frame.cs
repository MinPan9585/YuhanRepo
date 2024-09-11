using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frame : MonoBehaviour
{
    public Transform player;
    public float frameSpeed;

    void Update()
    {
        if (player.position.x < -9.7f)
        {
            this.transform.position = new Vector3(-9.7f * frameSpeed, this.transform.position.y, this.transform.position.z);
        }
        if (player.position.x > 9.6f)
        {
            this.transform.position = new Vector3(9.6f * frameSpeed, this.transform.position.y, this.transform.position.z);
        }
        if (player.position.x >= -9.7f && player.position.x <= 9.6f)
        {
            this.transform.position = new Vector3(player.position.x * frameSpeed, this.transform.position.y, this.transform.position.z);
        }
        
    }
}
