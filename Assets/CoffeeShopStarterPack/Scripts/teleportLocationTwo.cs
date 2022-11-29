using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Tracking.Collision;

public class teleportLocationTwo : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void button_pressed(CollisionNotifier.EventData data)
    {
        player.transform.position = new Vector3(-24, 8, 23);
    }
}
