using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    Vector3 lastPosition;

    int framesWithoutMoving;

    private void Start()
    {

        //initializes lastposition as current position 
        lastPosition = transform.position;
    }

    //Compares last position and current position tot see is ball has stopped for at least 10 frames
    public bool IsBallStopped()
    {

        bool didBallMove = (transform.position - lastPosition).magnitude > .0001f;

        lastPosition = transform.position;

        if (didBallMove)
        {

            framesWithoutMoving = 0;
        }
        else
        {
            framesWithoutMoving += 1;
        }

        return framesWithoutMoving >=10;
    }


    private void Update()
    {
        IsBallStopped();


    }

}
