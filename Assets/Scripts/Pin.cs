using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    Vector3 lastPosition;

    Quaternion lastRotation;

    int framesWithoutMoving;

    public bool pinfell;

   public Vector3 initialPinPosition;

   public Quaternion initialPinRotation;



    private void Start()
    {

        initialPinPosition = transform.position;

        initialPinRotation = transform.rotation;

        //initializes lastposition as current position 
        lastPosition = transform.position;

       
        pinfell = false;
    }

    //Compares last position and current position tot see is ball has stopped for at least 10 frames
   /* public bool DidPinFall()
    {
        bool didPinFall = (transform.position - lastPosition).magnitude > .0001f || Quaternion.Angle(transform.rotation, lastRotation) > .01f;

        lastPosition = transform.position;

        lastRotation = transform.rotation;

        if (didPinFall)
        {

            framesWithoutMoving = 0;
        }
        else
        {
            framesWithoutMoving += 1;
        }


        return framesWithoutMoving <= 10;
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Floor") {

            pinfell = true;
        }
    }


    private void Update()
    {
       
    }

}
