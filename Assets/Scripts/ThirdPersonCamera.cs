using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
   
    private GameObject bowlingBall;


    [SerializeField]
    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        bowlingBall = GameObject.FindGameObjectWithTag("Ball");

        if (bowlingBall != null)
        {
            transform.position = bowlingBall.transform.position + offset;
        }
    }
}
