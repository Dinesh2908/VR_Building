using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{

    public Transform PointA;
    public Transform PointB;
    public bool MoveBack;
    public NavMeshAgent Object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveBack == true){
            Object.SetDestination(PointA.position);

            if(!Object.pathPending){
                if(Object.remainingDistance <= Object.stoppingDistance){
                    Object.SetDestination(PointB.position);
                    MoveBack = false;
                }
            }
        }
        else{
            Object.SetDestination(PointB.position);
            if(!Object.pathPending){
                if(Object.remainingDistance <= Object.stoppingDistance){
                    MoveBack = true;
                }
            }

        }
    }
}
