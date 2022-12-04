using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Tracking.Collision;

public class spawn_soda : MonoBehaviour
{
    public AudioSource sound;

    public GameObject prefab;

    public Vector3 spawnPosition;



    void Start()
    {

    }

    public void button_pressed(CollisionNotifier.EventData data)
    {
        sound.Play();
        StartCoroutine(process_item());
    }

    public IEnumerator process_item()
    {
        yield return new WaitWhile(() => sound.isPlaying);
        Instantiate(prefab, spawnPosition, Quaternion.identity);
    }

}
