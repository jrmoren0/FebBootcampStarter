using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
   

    public Pin[] Pins;

    [SerializeField]
    private PlayController playController;

    [SerializeField]
    float resetTime;


    [SerializeField]
    private Vector3 intitalCamPosition;

    [SerializeField]
    private TMP_Text frameTotalScore;

    [SerializeField]
    private TMP_Text frameNumber;

    [SerializeField]
    private TMP_Text frame1stThrowScore;

    [SerializeField]
    private TMP_Text frame2ndThrowScore;

    private int totalScore = 0;

    private int currentFrame;

    private int currentScore;

    [SerializeField]
    private AudioSource strike;

    [SerializeField]
    private AudioSource rolling;


    private void Start()
    {
        resetTime = 4.0f;
        intitalCamPosition = Camera.main.transform.position;
        currentFrame = 1;

    }

    private void Update()
    {
        if (playController.wasBallThrown)
        {
            rolling.Play();
            playController.wasBallThrown = false;
            Invoke("CountFallenPins", resetTime);
            Invoke("ResetCamera", resetTime);
            Invoke("ResetPins", resetTime + 1f);

        }
    }



    private void CountFallenPins()
    {
        currentScore = 0;

        foreach(var pin in Pins)
        {
            if (pin.pinfell)
            {
                currentScore += 1;
                totalScore += 1;
            }
        }

        NextFrame();
        UpdateUI();
       


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
            pin.pinfell = false;
        }
        foreach (var pin in Pins)
        {
            pin.GetComponent<Rigidbody>().isKinematic = false;
        }
    }




    private void NextFrame()
    {
        if(currentFrame < 2)
        {
            currentFrame += 1;
        }
        else
        {
            currentFrame = 1;
        }
    }

    private void UpdateUI()
    {
        frameTotalScore.text = totalScore.ToString();
        frameNumber.text = currentFrame.ToString();

        if(currentFrame == 1)
        {
            frame1stThrowScore.text = currentScore.ToString();
        }
        else
        {
            frame2ndThrowScore.text = currentScore.ToString();
        }




    }




}
