using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstScript : MonoBehaviour
{

   [SerializeField]
   private Rigidbody bowlingBallRigidbody;


    // Start is called before the first frame update
    void Start()
    {
       //bowlingBallRigidbody.AddForce(transform.forward * 1000);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -1); //transform.forward;
    }
}
