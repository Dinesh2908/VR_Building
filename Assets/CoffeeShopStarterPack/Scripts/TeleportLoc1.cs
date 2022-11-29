using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Tracking.Collision;

public class TeleportLoc1 : MonoBehaviour
{
    public GameObject player;


    void Start()
    {

    }

    public void button_pressed(CollisionNotifier.EventData data)
    {
        player.transform.position = new Vector3(-29, 5, 9);
    }
}
