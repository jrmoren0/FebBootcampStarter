using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score = 0;

    public Pin[] Pins;

    [SerializeField]
    private PlayController playController;

    [SerializeField]
    float resetTime;


    [SerializeField]
    private Vector3 intitalCamPosition;


    private void Start()
    {
        resetTime = 4.0f;
        intitalCamPosition = Camera.main.transform.position;

    }

    private void Update()
    {
        if (playController.wasBallThrown)
        {
            playController.wasBallThrown = false;
            Invoke("CountFallenPins", resetTime);
            Invoke("ResetCamera", resetTime);
            Invoke("ResetPins", resetTime + 1f);

        }
    }



    private void CountFallenPins()
    {
        foreach(var pin in Pins)
        {
            if (pin.pinfell)
            {
                score += 1;
            }
        }

        Debug.Log(score);

    }

    private void ResetCamera() {

        Camera.main.transform.position = intitalCamPosition;

    }


    private void ResetPins()
    {
        foreach (var pin in Pins)
        {
            pin.transform.rotation = pin.initialPinRotation;
            pin.transform.position = pin.initialPinPosition;
            pin.GetComponent<Rigidbody>().isKinematic = true;
        }
        foreach (var pin in Pins)
        {
            pin.GetComponent<Rigidbody>().isKinematic = false;
        }
    }









}
