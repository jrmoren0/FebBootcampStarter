using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score = 0;

    public Pin[] Pins;

    public void CountFallenPins()
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








}
