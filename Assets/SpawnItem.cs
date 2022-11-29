using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Tracking.Collision;

public class SpawnItem : MonoBehaviour
{
   // public GameObject prefab;

    public GameObject player;

   // public Vector3 spawnPosition;


    void Start()
    {

    }

    public void button_pressed(CollisionNotifier.EventData data)
    {
       // Instantiate(prefab, spawnPosition, Quaternion.identity);
        player.transform.position = new Vector3(-18, 9, 22);
    }

}
